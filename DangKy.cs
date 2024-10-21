using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txbDKTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDKMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDKNhapLaiMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDKDangKy_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản và mật khẩu từ các TextBox
            string username = txbDKTaiKhoan.Text.Trim();
            string password = txbDKMatKhau.Text.Trim();
            string confirmPassword = txbDKNhapLaiMK.Text.Trim();

            // Kiểm tra mật khẩu có khớp với xác nhận mật khẩu không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuỗi kết nối
            string connectionString = @"Data Source=LAPTOP-Q30JB24O\SQLEXPRESS;Initial Catalog=QuanLyThuTienMang;Integrated Security=True";

            // Câu truy vấn SQL để kiểm tra xem tài khoản đã tồn tại chưa
            string queryCheckUsername = "SELECT COUNT(1) FROM tblTaiKhoan WHERE sTaiKhoan = @username";

            // Câu truy vấn SQL để thêm tài khoản mới
            string queryInsertAccount = "INSERT INTO tblTaiKhoan (sTaiKhoan, sMatKhau) VALUES (@username, @password)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    using (SqlCommand cmdCheck = new SqlCommand(queryCheckUsername, conn))
                    {
                        // Thêm tham số cho câu truy vấn kiểm tra tài khoản
                        cmdCheck.Parameters.AddWithValue("@username", username);

                        // Thực thi câu lệnh kiểm tra xem tài khoản đã tồn tại chưa
                        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (count == 1) // Nếu tài khoản đã tồn tại
                        {
                            MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Nếu tài khoản chưa tồn tại, thực hiện thêm tài khoản mới
                    using (SqlCommand cmdInsert = new SqlCommand(queryInsertAccount, conn))
                    {
                        // Thêm tham số cho câu truy vấn thêm tài khoản
                        cmdInsert.Parameters.AddWithValue("@username", username);
                        cmdInsert.Parameters.AddWithValue("@password", password);

                        // Thực thi câu lệnh thêm tài khoản
                        cmdInsert.ExecuteNonQuery();

                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Quay lại form đăng nhập sau khi đăng ký thành công
                        DangNhap dn = new DangNhap();
                        dn.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi kết nối hoặc lỗi trong quá trình thực thi câu lệnh
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnDKDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
