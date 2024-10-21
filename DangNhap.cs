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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }


        private void btnDNDangNhap_Click(object sender, EventArgs e)
        {
            // Lấy thông tin tài khoản và mật khẩu từ các TextBox
            string username = txbDNTaiKhoan.Text.Trim();
            string password = txbDNMatKhau.Text.Trim();

            // Chuỗi kết nối
            string connectionString = @"Data Source=LAPTOP-Q30JB24O\SQLEXPRESS;Initial Catalog=QuanLyThuTienMang;Integrated Security=True";

            // Câu truy vấn SQL để kiểm tra tài khoản và mật khẩu
            string query = "SELECT COUNT(1) FROM tblTaiKhoan WHERE sTaiKhoan = @username AND sMatKhau = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số cho câu truy vấn
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        // Thực thi câu truy vấn và lấy kết quả
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1) // Nếu tồn tại tài khoản
                        {
                            // Hiển thị form chính và ẩn form đăng nhập
                            FormMain fm = new FormMain();
                            fm.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Hiển thị thông báo lỗi nếu sai tài khoản hoặc mật khẩu
                            MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi kết nối hoặc lỗi trong quá trình thực thi câu lệnh
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void btnDNDangKy_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            this.Hide();
        }

        private void checkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienMK.Checked)
            {
                txbDNMatKhau.PasswordChar = '\0';
            }
            else
            {
                txbDNMatKhau.PasswordChar = '•';
            }
        }

        private void btnDNThoat_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                {
                    this.Close();
                }
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txbDNTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDNMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
