using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BTL
{
    public class DBConnection
    {
        public DataSet DataSet => _dataSet;
        public static DBConnection Instance => _instance;

        private static DBConnection _instance = new DBConnection();

        private DataSet _dataSet = new DataSet();

        public SqlConnection CreateConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            return new SqlConnection(constr);
        }

        public DataTable SelectDB(string table)
        {
            using (SqlConnection cnn = CreateConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = cnn.BuildSelectCommand(table))
                    {
                        try
                        {
                            da.SelectCommand = cmd;
                            _dataSet.Tables[table]?.Clear();
                            cnn.Open();
                            da.Fill(_dataSet, table);
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Lỗi select DataBase : " + ex.Message);
                        }
                    }
                }
            }
            return _dataSet.Tables[table];
        }

        public bool InsertDB(string table, params SqlParameter[] sqlParameters)
        {
            using (SqlConnection cnn = CreateConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = cnn.BuildInsertCommand(table, sqlParameters))
                    {
                        try
                        {
                            da.InsertCommand = cmd;
                            DataRow newRow = _dataSet.Tables[table].NewRow();
                            foreach (var p in sqlParameters)
                            {
                                newRow[p.SourceColumn] = p.Value;
                            }
                            _dataSet.Tables[table].Rows.Add(newRow);
                            cnn.Open();
                            int i = da.Update(_dataSet, table);
                            cnn.Close();
                            return i > 0;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Lỗi insert DataBase : " + ex.Message);
                        }
                    }

                }
            }
        }

        public bool InsertDB(string table, string nameProc,params SqlParameter[] sqlParameters)
        {
            if (_dataSet.Tables[table] == null) SelectDB(table);

            using (SqlConnection cnn = CreateConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = cnn.BuildInsertProc(nameProc, sqlParameters))
                    {
                        try
                        {
                            da.InsertCommand = cmd;
                            DataRow newRow = _dataSet.Tables[table].NewRow();
                            foreach (var p in sqlParameters)
                            {
                                newRow[p.SourceColumn] = p.Value;
                            }
                            _dataSet.Tables[table].Rows.Add(newRow);
                            cnn.Open();
                            int i = da.Update(_dataSet, table);
                            cnn.Close();
                            return i > 0;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Lỗi insert DataBase : " + ex.Message);
                        }
                    }

                }
            }
        }

        public DataRow GetRow(string table, SqlParameter parameter)
        {
            if (_dataSet.Tables[table] == null) SelectDB(table);

            foreach (DataRow row in _dataSet.Tables[table].Rows)
            {
                if (row[parameter.SourceColumn].Equals(parameter.Value))
                    return row;
            }
            return null;
        }


        public bool UpdateDB(string table, SqlParameter condition, params SqlParameter[] sqlParameters)
        {
            DataTable dt = _dataSet.Tables[table];
            if (_dataSet.Tables[table] == null)
            {
                dt = SelectDB(table);
            }

            using (SqlConnection cnn = CreateConnection())
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    using (SqlCommand cmd = cnn.BuildUpdateCommand(table, condition, sqlParameters))
                    {
                        try
                        {
                            da.UpdateCommand = cmd;
                            cnn.Open();

                            var row = GetRow(table, condition);

                            foreach (var p in sqlParameters)
                            {
                                row[p.SourceColumn] = p.Value;
                            }
                            int i = da.Update(_dataSet, table);
                            cnn.Close();
                            return i > 0;
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Lỗi update DataBase : " + ex.Message);
                        }
                    }

                }
            }
        }
    }
}
