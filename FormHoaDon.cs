using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormHoaDon : Form
    {
        private int _maHoaDon;
        public FormHoaDon(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            var row = DBConnection.Instance.GetRow("vHoaDon", "iMaHoaDon", _maHoaDon);

            grThongTinHoaDon.Text += $" {row.Field<int>("iMaHoaDon")}";
            var dataKH = DBConnection.Instance.GetRow("tblKhachHang", "iMaKhachHang", row.Field<int>("iMaKhachHang"));
            txtKhachHang.Text = $"{dataKH["sHoTen"]} [{dataKH["iMaKhachHang"]}]";

            var dataNV = DBConnection.Instance.GetRow("tblNhanVien", "iMaNhanVien", row.Field<int>("iMaNhanVien"));
            txtNhanVien.Text = $"{dataNV["sHoTen"]} [{dataNV["iMaNhanVien"]}]";

            dtpHDNgayTao.Value = row.Field<DateTime>("dNgayTao");


            cboMaMang.LoadDataSource("tblMang", "sTenMang", "iMaMang");
            cboMaMang.Format += (s, e) =>
            {
                DataRowView row = (DataRowView)e.ListItem;
                e.Value = $"{row["sTenMang"]} [{row["iMaMang"]}]";
            };


            dtThongTinCTHoaDon.LoadDataSource("vChiTietHoaDon", $"iMaHoaDon={row.Field<int>("iMaHoaDon")}");
            dtThongTinCTHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtThongTinCTHoaDon.Columns[1].HeaderText = "Mã CT Hóa Đơn";
            dtThongTinCTHoaDon.Columns[2].HeaderText = "Tên Mạng";
            dtThongTinCTHoaDon.Columns[4].HeaderText = "Đơn giá";
            dtThongTinCTHoaDon.Columns[5].HeaderText = "Số tháng đăng ký";

            dtThongTinCTHoaDon.Columns[0].Visible = false;
            dtThongTinCTHoaDon.Columns[1].Width = 190;
            dtThongTinCTHoaDon.Columns[2].Width = 150;
            dtThongTinCTHoaDon.Columns[3].Visible = false;
            dtThongTinCTHoaDon.Columns[4].Width = 150;
            dtThongTinCTHoaDon.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lblTotal.Text = $"Tổng tiền : {row.Field<int>("iTongTien")} đ";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var table = (dtThongTinCTHoaDon.DataSource as DataView).Table;
            try
            {
                DBConnection.Instance.InsertDB("tblChiTietHoaDon", "sp_ThemChiTietHoaDon",
                DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", _maHoaDon),
                DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", cboMaMang.SelectedValue),
                DBConnection.Instance.BuildParameter("@iSoThangDangKy", SqlDbType.Int, 0, "iSoThangDangKy", int.Parse(txtSoThangDK.Text)));

                DBConnection.Instance.SelectDB("vChiTietHoaDon", $"iMaHoaDon={_maHoaDon}");

                DBConnection.Instance.SelectDB("vHoaDon");
                var row = DBConnection.Instance.GetRow("vHoaDon", "iMaHoaDon", _maHoaDon);

                lblTotal.Text = $"Tổng tiền : {row.Field<int>("iTongTien")} đ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSoThangDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Instance.SelectDB("vHoaDon");
            DBConnection.Instance.SelectDB("vChiTietHoaDon");
        }
    }
}
