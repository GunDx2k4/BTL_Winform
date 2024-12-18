﻿using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace BTL
{
    /// <summary>
    /// Đây gọi là lớp mở rộng giúp bổ sung các chức năng 
    /// <br/>
    /// Lớp này chứa tất cả các phần mở rộng của tất cả các lớp và có thể là cả các kiểu dữ liệu
    /// <br/>
    /// Để tạo mới phương thức mở rộng cho các lớp khác thì thêm this [Tên lớp cần tạo hàm mở rộng] vào hàm mở rộng  
    /// <br/>
    /// VD : Đây là hàm mở rộng cho string
    /// <br/>
    /// public static void ExtensionString(this string str)
    /// <br/>
    ///     {
    /// <br/>
    ///         Console.Write($"Hello {str}");
    /// <br/>
    ///     }
    /// <br/>
    /// 
    /// </summary>
    public static class Extension
    {
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Biểu thức chính quy để kiểm tra email
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
        public static bool IsValidPhoneNumber(this string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Biểu thức chính quy để kiểm tra số điện thoại (ví dụ cho số điện thoại Việt Nam)
            var phonePattern = @"^(\+84|0)\d{9}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, phonePattern);
        }

        public static bool IsValidAddress(this string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return false;

            // Bạn có thể thêm các quy tắc khác nếu cần
            return true;
        }

        public static bool IsValidName(this string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Biểu thức chính quy để kiểm tra họ tên
            var namePattern = @"^[\p{L} .'-]+$"; // Chấp nhận chữ, khoảng trắng, dấu chấm, dấu gạch nối
            return System.Text.RegularExpressions.Regex.IsMatch(name, namePattern);
        }

        /// <summary>
        /// Thêm . vào số VD : 1000 => 1.000
        /// </summary>
        /// <param name="column"></param>
        public static void SetFormatMoneys(this DataGridViewColumn column)
        {
            column.DefaultCellStyle.Format = "N0";
            column.DefaultCellStyle.FormatProvider = new CultureInfo("vi-VN");
        }
        /// <summary>
        /// Thêm . vào số VD : 1000 => 1.000
        /// </summary>
        /// <returns></returns>
        public static string GetMoneys(this int m)
        {
            return m.ToString("N0", new CultureInfo("vi-VN"));
        }

        /// <summary>
        /// Hàm kiểm tra <see cref="TextBox.Text"/> có rỗng hay không có gì không
        /// </summary>
        /// <param name="txts">Các <see cref="TextBox"/> cần kiểm tra</param>
        /// <returns><c>True</c> Nếu có <see cref="TextBox"/> rỗng hoặc không có gì và sẽ hiện ra thông báo, ngược lại trả về <c>False</c> và không có thông báo</returns>
        public static bool TextIsNullOrEmpty(this Form form, params TextBox[] txts)
        {
            foreach (var txt in txts)
            {
                txt.Text = txt.Text.Trim();
                if (string.IsNullOrEmpty(txt.Text) || string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("Không được để dữ liệu rỗng");
                    txt.Focus();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Hàm thêm <see cref="ComboBox.DataSource"/> cho <see cref="ComboBox"/>
        /// </summary>
        /// <param name="table">Tên bảng</param>
        /// <param name="displayMember">Thuộc tính hiển thị</param>
        /// <param name="valueMember">Thuộc tính làm giá trị</param>
        /// <param name="query">(Nếu có) Mã SQL sau WHERE VD: "bDeleted=0 AND sHoTen LIKE %N%"</param>
        public static void LoadDataSource(this ComboBox cbo, string table, string displayMember, string valueMember, string query = "")
        {
            cbo.DataSource = DBConnection.Instance.SelectDB(table, query).CreateDataView();
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
        }

        /// <summary>
        /// Hàm thêm <see cref="DataGridView.DataSource"/> cho <see cref="DataGridView"/>
        /// </summary>
        /// <param name="table">Tên bảng</param>
        /// <param name="query">(Nếu có) Mã SQL sau WHERE VD: "bDeleted=0 AND sHoTen LIKE %N%"</param>
        public static void LoadDataSource(this DataGridView grv, string table, string query = "")
        {
            grv.DataSource = DBConnection.Instance.SelectDB(table, query).CreateDataView();
            if (grv.Columns["bDeleted"] != null)
                grv.Columns["bDeleted"].Visible = false;
        }

        /// <summary>
        /// Hàm thêm bộ lọc cho <see cref="DataView"/>
        /// </summary>
        /// <param name="filter">Mã SQL để tạo bộ lọc VD:"bDeleted=0 AND sHoTen LIKE %Nguyễn%"</param>
        /// <returns>nếu bảng có bDeleted sẽ tự động thêm bDeleted=0</returns>
        public static void AddRowFilter(this DataView dataView, string filter)
        {
            if (dataView.Table.Columns["bDeleted"] != null)
            {
                dataView.RowFilter = $"bDeleted=0 AND {filter}";
                return;
            }
            dataView.RowFilter = $"{filter}";
        }

        /// <summary>
        /// Hàm tạo <see cref="DataView"/> cho <see cref="DataTable"/>
        /// </summary>
        /// <returns>nếu bảng có bDeleted sẽ tự động thêm <see cref="DataView.RowFilter"/> bDeleted=0</returns>
        public static DataView CreateDataView(this DataTable table)
        {
            if (table.Columns["bDeleted"] == null)
                return new DataView(table);
            return new DataView(table) { RowFilter = "bDeleted=0" };
        }

        /// <summary>
        /// Hàm tạo <see cref="SqlCommand"/> là <see cref="CommandType.Text"/> dùng để Select
        /// </summary>
        /// <param name="table">Tên bảng cần tạo</param>
        /// <param name="query">(Nếu có) Mã SQL sau WHERE VD: "bDeleted=0 AND sHoTen LIKE %N%"</param>
        /// <returns></returns>
        public static SqlCommand BuildSelectCommand(this SqlConnection conn, string table, string query = "")
        {
            string sqlSelect = $"SELECT * FROM {table} " + (string.IsNullOrEmpty(query) ? "" : $"WHERE {query}");
            return new SqlCommand(sqlSelect, conn);
        }

        /// <summary>
        /// Hàm tạo <see cref="SqlCommand"/> là <see cref="CommandType.StoredProcedure"/> dùng để Insert
        /// </summary>
        /// <param name="nameProc">Tên hàm sử dụng trong để thêm dữ liệu</param>
        /// <param name="sqlParameters">Các thuộc tính cần thêm vào bảng (sử dụng <see cref="DBConnection.BuildParameter)"/> để tạo ra parameter cho chuẩn dạng dữ liệu)</param>
        /// <returns></returns>
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

        /// <summary>
        /// Hàm tạo <see cref="SqlCommand"/> là <see cref="CommandType.Text"/> dùng để Insert
        /// </summary>
        /// <param name="table">Tên bảng</param>
        /// <param name="sqlParameters">Các thuộc tính cần thêm vào bảng (sử dụng <see cref="DBConnection.BuildParameter)"/> để tạo ra parameter cho chuẩn dạng dữ liệu)</param>
        /// <returns></returns>
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

        /// <summary>
        /// Hàm tạo <see cref="SqlCommand"/> là <see cref="CommandType.Text"/> dùng để Update
        /// </summary>
        /// <param name="table">Tên bảng</param>
        /// <param name="condition">Tên điều kiện cập nhật (sử dụng <see cref="DBConnection.BuildParameter)"/> để tạo ra parameter cho chuẩn dạng dữ liệu)</param>
        /// <param name="sqlParameters">Các thuộc tính cần cập nhật vào bảng (sử dụng <see cref="DBConnection.BuildParameter)"/> để tạo ra parameter cho chuẩn dạng dữ liệu)</param>
        /// <returns></returns>
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
