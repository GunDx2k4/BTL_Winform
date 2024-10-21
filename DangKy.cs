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
            if (this.TextIsNullOrEmpty(txbDKTaiKhoan, txbDKMatKhau, txbDKNhapLaiMK)) return;
            // Lấy thông tin tài khoản và mật khẩu từ các TextBox
            string username = txbDKTaiKhoan.Text;
            string password = txbDKMatKhau.Text;
            string confirmPassword = txbDKNhapLaiMK.Text;

            // Kiểm tra mật khẩu có khớp với xác nhận mật khẩu không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var table = DBConnection.Instance.SelectDB("tblTaiKhoan", $"sTaiKhoan = '{username}'");
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool checkInsert = DBConnection.Instance.InsertDB("tblTaiKhoan",
                    DBConnection.Instance.BuildParameter("@username", SqlDbType.NVarChar, 100, "sTaiKhoan", username),
                    DBConnection.Instance.BuildParameter("@password", SqlDbType.NVarChar, 100, "sMatKhau", password));
                if (checkInsert)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Quay lại form đăng nhập sau khi đăng ký thành công
                    DangNhap dn = new DangNhap();
                    dn.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnDKDangNhap_Click(object sender, EventArgs e)
        {

        }

    }
}