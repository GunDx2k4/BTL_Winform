using System;
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
            if (this.TextIsNullOrEmpty(txbDNMatKhau, txbDNTaiKhoan)) return;
            // Lấy thông tin tài khoản và mật khẩu từ các TextBox
            string username = txbDNTaiKhoan.Text;
            string password = txbDNMatKhau.Text;

            try
            {
                var table = DBConnection.Instance.SelectDB("tblTaiKhoan", $"sTaiKhoan = '{username}' AND sMatKhau = '{password}'");
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FormMain fm = new FormMain();
                fm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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