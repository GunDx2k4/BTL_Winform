using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
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

                dtThongTinHoaDon.LoadDataSource("tblHoaDon", "bDeleted=0");
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

                dtThongTinCTHoaDon.LoadDataSource("tblChiTietHoaDon");
                dtThongTinCTHoaDon.Columns[0].HeaderText = "Mã CT Hóa Đơn";
                dtThongTinCTHoaDon.Columns[1].HeaderText = "Mã Hóa Đơn";
                dtThongTinCTHoaDon.Columns[2].HeaderText = "Mã Mạng";
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

                cboMaNV.LoadDataSource("tblNhanVien", "sHoTen", "iMaNhanVien");

                cboMaNV.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sHoTen"]} [{row["iMaNhanVien"]}]";
                };

                cboMaKH.LoadDataSource("tblKhachHang", "sHoTen", "iMaKhachHang");
                cboMaKH.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sHoTen"]} [{row["iMaKhachHang"]}]";
                };


                cboMaHD.LoadDataSource("tblHoaDon", "iMaHoaDon", "iMaHoaDon");

                cboMaMang.LoadDataSource("tblMang", "sTenMang", "iMaMang");
                cboMaMang.Format += (s, e) =>
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            MessageBox.Show(comboBox.SelectedValue.ToString());
        }

        private void buttonNvInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                new SqlParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen") { Value = textBoxHoTen.Text },
                new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai") { Value = textBoxSDT.Text },
                new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi") { Value = textBoxDiaChi.Text },
                new SqlParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail") { Value = textBoxEmail.Text });
                DBConnection.Instance.SelectDB("tblKhachHang");
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

        private void dtThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtThongTinHoaDon.Columns["btnCTHoaDon"].Index && e.RowIndex >= 0)
            {
                new FormHoaDon().ShowDialog();
            }
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            new FormHoaDon().ShowDialog();
        }
    }
}
