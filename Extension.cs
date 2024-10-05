using System.Data;
using System.Data.SqlClient;

namespace BTL
{
    public static class Extension
    {
        public static void AddRowFilter(this DataView dataView, string filter)
        {
            dataView.RowFilter = $"bDeleted=0 AND {filter}";
        }

        public static DataView CreateDataView(this DataTable table)
        {
            return new DataView(table) { RowFilter = "bDeleted=0" };
        }

        public static SqlCommand BuildSelectCommand(this SqlConnection conn, string table) 
        {
            return new SqlCommand($"SELECT * FROM {table} WHERE bDeleted=0 ", conn);
        }

        public static SqlCommand BuildInsertProc(this SqlConnection conn, string nameProc, params SqlParameter[] sqlParameters)
        {
            var cmd = new SqlCommand(nameProc, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (var param in sqlParameters)
            {
                cmd.Parameters.Add(param);
            }

            return cmd;
        }
        public static SqlCommand BuildInsertCommand(this SqlConnection conn, string table, params SqlParameter[] sqlParameters)
        {
            string sqlInsert = $"INSERT INTO {table}(";
            string value = " VALUES (";
            for (int i = 0; i < sqlParameters.Length; i++)
            {
                var param = sqlParameters[i];

                if (i == sqlParameters.Length - 1)
                {
                    sqlInsert += $"{param.SourceColumn})";
                    value += $"{param.ParameterName})";
                }
                else
                {
                    sqlInsert += $"{param.SourceColumn},";
                    value += $"{param.ParameterName},";
                }
            }
            sqlInsert += value;
            var cmd = new SqlCommand(sqlInsert, conn);
            foreach (var param in sqlParameters)
            {
                cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
            }
            return cmd;
        }

        public static SqlCommand BuildUpdateCommand(this SqlConnection conn, string table, SqlParameter condition, params SqlParameter[] sqlParameters)
        {
            string sqlUpdate = $"UPDATE {table} SET ";

            for (int i = 0; i < sqlParameters.Length; i++)
            {
                var param = sqlParameters[i];

                sqlUpdate += $"{param.SourceColumn}={param.ParameterName}";

                if (i < sqlParameters.Length - 1) sqlUpdate += ", ";
            }

            sqlUpdate += $" WHERE {condition.SourceColumn}={condition.ParameterName}";

            var cmd = new SqlCommand(sqlUpdate, conn);
            foreach (var param in sqlParameters)
            {
                cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
            }
            cmd.Parameters.AddWithValue(condition.ParameterName, condition.Value);
            return cmd;
        }
    }
}
