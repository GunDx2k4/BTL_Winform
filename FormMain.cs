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
                dtThongTinKhachHang.LoadDataSource("tblKhachHang");
                dtThongTinKhachHang.Columns[0].HeaderText = "MKH";
                dtThongTinKhachHang.Columns[1].HeaderText = "Họ Tên";
                dtThongTinKhachHang.Columns[2].HeaderText = "SDT";
                dtThongTinKhachHang.Columns[3].HeaderText = "Địa Chỉ";
                dtThongTinKhachHang.Columns[4].HeaderText = "Email";

                dtThongTinKhachHang.Columns[0].Width = 75;
                dtThongTinKhachHang.Columns[1].Width = 130;
                dtThongTinKhachHang.Columns[2].Width = 120;
                dtThongTinKhachHang.Columns[3].Width = 190;
                dtThongTinKhachHang.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinNhanVien.LoadDataSource("tblNhanVien");
                dtThongTinNhanVien.Columns[0].HeaderText = "Ma Nhân Viên";
                dtThongTinNhanVien.Columns[1].HeaderText = "Họ Tên NV";
                dtThongTinNhanVien.Columns[2].HeaderText = "Chức Vụ";
                dtThongTinNhanVien.Columns[3].HeaderText = "SDT";

                dtThongTinNhanVien.Columns[0].Width = 150;
                dtThongTinNhanVien.Columns[1].Width = 190;
                dtThongTinNhanVien.Columns[2].Width = 150;
                dtThongTinNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinHoaDon.LoadDataSource("tblHoaDon");
                dtThongTinHoaDon.Columns[0].HeaderText = "Ma Nhân Viên";
                dtThongTinHoaDon.Columns[1].HeaderText = "Họ Tên NV";
                dtThongTinHoaDon.Columns[2].HeaderText = "Chức Vụ";
                dtThongTinHoaDon.Columns[3].HeaderText = "SDT";

                dtThongTinHoaDon.Columns[0].Width = 150;
                dtThongTinHoaDon.Columns[1].Width = 190;
                dtThongTinHoaDon.Columns[2].Width = 150;
                dtThongTinHoaDon.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //sửa
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = dataGridView2.CurrentRow.Cells[0].Value },
                new SqlParameter("@sHoTen", SqlDbType.Bit, 0, "sHoTen") { Value = "test434" },
                new SqlParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai") { Value = "test2" },
                new SqlParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi") { Value = "test2" },
                new SqlParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail") { Value = "test2" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //tìm
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = dataGridView2.DataSource as DataView;
                dataView.AddRowFilter($"sHoTen LIKE '%{textBox1.Text}%'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //xóa
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Nên viết thứ tự parameter theo tứ tự trong DataBase
                DBConnection.Instance.UpdateDB("tblKhachHang",
                new SqlParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang") { Value = dataGridView2.CurrentRow.Cells[0].Value },
                new SqlParameter("@bDeleted", SqlDbType.Bit, 0, "bDeleted") { Value = true });
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
    }
}
