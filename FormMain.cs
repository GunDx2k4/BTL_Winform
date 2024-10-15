using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

            try
            {
                dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");
                dtThongTinKhachHang.Columns[0].HeaderText = "MKH";
                dtThongTinKhachHang.Columns[1].HeaderText = "Họ Tên";
                dtThongTinKhachHang.Columns[2].HeaderText = "SDT";
                dtThongTinKhachHang.Columns[3].HeaderText = "Địa Chỉ";
                dtThongTinKhachHang.Columns[4].HeaderText = "Email";

                dtThongTinKhachHang.Columns[0].Width = 75;
                dtThongTinKhachHang.Columns[1].Width = 190;
                dtThongTinKhachHang.Columns[2].Width = 120;
                dtThongTinKhachHang.Columns[3].Width = 150;
                dtThongTinKhachHang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");
                dtThongTinNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
                dtThongTinNhanVien.Columns[1].HeaderText = "Họ Tên NV";
                dtThongTinNhanVien.Columns[2].HeaderText = "SDT";
                dtThongTinNhanVien.Columns[3].HeaderText = "Địa Chỉ";

                dtThongTinNhanVien.Columns[0].Width = 150;
                dtThongTinNhanVien.Columns[1].Width = 190;
                dtThongTinNhanVien.Columns[2].Width = 150;
                dtThongTinNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinHoaDon.LoadDataSource("vHoaDon");
                dtThongTinHoaDon.Columns[0].HeaderText = "Mã HĐ";
                dtThongTinHoaDon.Columns[1].HeaderText = "Mã KH";
                dtThongTinHoaDon.Columns[2].HeaderText = "Mã NV";
                dtThongTinHoaDon.Columns[3].HeaderText = "Ngày Tạo";
                dtThongTinHoaDon.Columns[4].HeaderText = "Tổng tiền";

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnCTHoaDon";
                btnColumn.HeaderText = "CT Hóa Đơn";
                btnColumn.Text = "Xem";
                btnColumn.UseColumnTextForButtonValue = true;
                dtThongTinHoaDon.Columns.Add(btnColumn);

                dtThongTinHoaDon.Columns[0].Width = 120;
                dtThongTinHoaDon.Columns[1].Width = 120;
                dtThongTinHoaDon.Columns[2].Width = 120;
                dtThongTinHoaDon.Columns[3].Width = 150;
                dtThongTinHoaDon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinCTHoaDon.LoadDataSource("vChiTietHoaDon");
                dtThongTinCTHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
                dtThongTinCTHoaDon.Columns[1].HeaderText = "Mã CT Hóa Đơn";
                dtThongTinCTHoaDon.Columns[2].HeaderText = "Tên Mạng";
                dtThongTinCTHoaDon.Columns[3].HeaderText = "Đơn giá";
                dtThongTinCTHoaDon.Columns[4].HeaderText = "Số tháng đăng ký";

                dtThongTinCTHoaDon.Columns[0].Width = 150;
                dtThongTinCTHoaDon.Columns[1].Width = 190;
                dtThongTinCTHoaDon.Columns[2].Width = 150;
                dtThongTinCTHoaDon.Columns[3].Width = 150;
                dtThongTinCTHoaDon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                dtThongTinMang.LoadDataSource("tblMang", "bDeleted=0");
                dtThongTinMang.Columns[0].HeaderText = "Mã Mạng";
                dtThongTinMang.Columns[1].HeaderText = "Tên Mạng";
                dtThongTinMang.Columns[2].HeaderText = "Mô Tả";
                dtThongTinMang.Columns[3].HeaderText = "Đơn giá";

                dtThongTinMang.Columns[0].Width = 150;
                dtThongTinMang.Columns[1].Width = 190;
                dtThongTinMang.Columns[2].Width = 190;
                dtThongTinMang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                txbHDMaNV.LoadDataSource("tblNhanVien", "sHoTen", "iMaNhanVien");

                txbHDMaNV.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sHoTen"]} [{row["iMaNhanVien"]}]";
                };

                txbHDMaKH.LoadDataSource("tblKhachHang", "sHoTen", "iMaKhachHang");
                txbHDMaKH.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sHoTen"]} [{row["iMaKhachHang"]}]";
                };


                txbCTHDMaHD.LoadDataSource("tblHoaDon", "iMaHoaDon", "iMaHoaDon");

                txbCTHDMaMang.LoadDataSource("tblMang", "sTenMang", "iMaMang");
                txbCTHDMaMang.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sTenMang"]} [{row["iMaMang"]}]";
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonNvInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbKHHoTen.Text),
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbKHSDT.Text),
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbKHDiaChi.Text),
                DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", txbKHEmail.Text));

                DBConnection.Instance.SelectDB("tblKhachHang", "bDeleted=0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNvUpdate_Click(object sender, EventArgs e)
        {

        }

        private void dtThongTinNhanVien_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("D:\\Code\\Project\\NAM 3\\HSK\\BTL\\CrystalReport1.rpt");
            new FormReport(report).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        #region Hóa Đơn [Dũng]
        private void dtThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.ColumnIndex == dgv.Columns["btnCTHoaDon"].Index && e.RowIndex >= 0)
            {
                var table = dgv.DataSource as DataView;
                new FormHoaDon(table.Table.Rows[e.RowIndex]).ShowDialog();
            }
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Instance.InsertDB("tblHoaDon", "sp_ThemHoaDon",
                DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", txbHDMaKH.SelectedValue),
                DBConnection.Instance.BuildParameter("@iMaNhanVien", SqlDbType.Int, 0, "iMaNhanVien", txbHDMaNV.SelectedValue),
                DBConnection.Instance.BuildParameter("@dNgayTao", SqlDbType.Date, 255, "dNgayTao", txbHDNgayTao.Value));

                var table = DBConnection.Instance.SelectDB("tblHoaDon", "bDeleted=0");

                new FormHoaDon(table.Rows[table.Rows.Count - 1]).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtThongTinHoaDon_CurrentCellChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            var table = (dgv.DataSource as DataView).Table;
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                var row = table.Rows[dgv.CurrentRow.Index];
                txbHDMaKH.SelectedValue = row.Field<int>("iMaKhachHang");
                txbHDMaNV.SelectedValue = row.Field<int>("iMaNhanVien");
                txbHDNgayTao.Value = row.Field<DateTime>("dNgayTao");
            }
        }

        #endregion

        private void tpNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNvDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHDThoat_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
