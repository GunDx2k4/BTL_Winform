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
        private DataRow _dataHoaDon;
        public FormHoaDon(DataRow row)
        {
            InitializeComponent();
            _dataHoaDon = row;
        }

        private float GetTotal()
        {
            var table = (dtThongTinCTHoaDon.DataSource as DataView).Table;
            float total = 0;
            foreach (DataRow row in table.Rows)
            {
                total += row.Field<int>("iDonGia") * row.Field<int>("iSoThangDangKy");
            }
            return total;

        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            grThongTinHoaDon.Text += $" {_dataHoaDon.Field<int>("iMaHoaDon")}";
            var dataKH = DBConnection.Instance.GetRow("tblKhachHang", "iMaKhachHang", _dataHoaDon.Field<int>("iMaKhachHang"));
            txtKhachHang.Text = $"{dataKH["sHoTen"]} [{dataKH["iMaKhachHang"]}]";

            var dataNV = DBConnection.Instance.GetRow("tblNhanVien", "iMaNhanVien", _dataHoaDon.Field<int>("iMaNhanVien"));
            txtNhanVien.Text = $"{dataNV["sHoTen"]} [{dataNV["iMaNhanVien"]}]";

            dtpHDNgayTao.Value = _dataHoaDon.Field<DateTime>("dNgayTao");


            cboMaMang.LoadDataSource("tblMang", "sTenMang", "iMaMang");
            cboMaMang.Format += (s, e) =>
            {
                DataRowView row = (DataRowView)e.ListItem;
                e.Value = $"{row["sTenMang"]} [{row["iMaMang"]}]";
            };


            dtThongTinCTHoaDon.LoadDataSource("vChiTietHoaDon", $"iMaHoaDon={_dataHoaDon.Field<int>("iMaHoaDon")}");
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var table = (dtThongTinCTHoaDon.DataSource as DataView).Table;
            try
            {
                DBConnection.Instance.InsertDB("tblChiTietHoaDon", "sp_ThemChiTietHoaDon",
                DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", _dataHoaDon.Field<int>("iMaHoaDon")),
                DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", cboMaMang.SelectedValue),
                DBConnection.Instance.BuildParameter("@iSoThangDangKy", SqlDbType.Int, 0, "iSoThangDangKy", int.Parse(txtSoThangDK.Text)));

                DBConnection.Instance.SelectDB("vChiTietHoaDon");
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
