using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 
using System.Collections.Generic;
using System.ComponentModel; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace BTL
{
    public partial class FormMain : Form
    {
        private string currentMaKH; // Biến để lưu mã khách hàng
        public bool isExit = true;
        int index = 0;
        private object yourDataSource;

        public FormMain()
        {
            InitializeComponent();
            // Đăng ký sự kiện SelectionChanged
            dtThongTinKhachHang.SelectionChanged += dtThongTinKhachHang_SelectionChanged;
        }
         
        #region Hỗ trợ

        private void btnKHThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                {
                    this.Close();
                }
            }
        }
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void EnableControl(bool isNableTextBox, bool isNableDataGridView)
        {
            dtThongTinKhachHang.Enabled = isNableDataGridView;
            txbKHHoTen.Enabled = txbKHSDT.Enabled = txbKHEmail.Enabled = txbKHDiaChi.Enabled = isNableTextBox;

        }
        private void ClearTextBoxes()
        {
            txbKHHoTen.Text = string.Empty;
            txbKHSDT.Text = string.Empty;
            txbKHDiaChi.Text = string.Empty;
            txbKHEmail.Text = string.Empty;
        }
        private void ClearTextBoxesNV()
        {
            txbNVHoTen.Text = string.Empty;
            txbNVDiaChi.Text = string.Empty;
            txbNVSDT.Text = string.Empty;
        }

        #endregion 
        #region Check
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Biểu thức chính quy để kiểm tra email
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
        }
        public bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            // Biểu thức chính quy để kiểm tra số điện thoại (ví dụ cho số điện thoại Việt Nam)
            var phonePattern = @"^(\+84|0)\d{9}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, phonePattern);
        }

        public bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            // Biểu thức chính quy để kiểm tra họ tên
            var namePattern = @"^[\p{L} .'-]+$"; // Chấp nhận chữ, khoảng trắng, dấu chấm, dấu gạch nối
            return System.Text.RegularExpressions.Regex.IsMatch(name, namePattern);
        }
        public bool IsValidAddress(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                return false;

            // Bạn có thể thêm các quy tắc khác nếu cần
            return true;
        }
        #endregion
        private void FormMain_Load(object sender, EventArgs e)
        {

            try
            {
                //  khách hàng
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


                // nhân viên
                dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");
                dtThongTinNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
                dtThongTinNhanVien.Columns[1].HeaderText = "Họ Tên NV";
                dtThongTinNhanVien.Columns[2].HeaderText = "SDT";
                dtThongTinNhanVien.Columns[3].HeaderText = "Địa Chỉ";

                dtThongTinNhanVien.Columns[0].Width = 150;
                dtThongTinNhanVien.Columns[1].Width = 190;
                dtThongTinNhanVien.Columns[2].Width = 150;
                dtThongTinNhanVien.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // hóa đơn
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

                // chi tiết hóa đơn 
                dtThongTinCTHoaDon.LoadDataSource("tblChiTietHoaDon", "bDeleted=0");
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

                // mạng
                dtThongTinMang.LoadDataSource("tblMang", "bDeleted=0");
                dtThongTinMang.Columns[0].HeaderText = "Mã Mạng";
                dtThongTinMang.Columns[1].HeaderText = "Tên Mạng";
                dtThongTinMang.Columns[2].HeaderText = "Mô Tả";
                dtThongTinMang.Columns[3].HeaderText = "Đơn giá";

                dtThongTinMang.Columns[0].Width = 150;
                dtThongTinMang.Columns[1].Width = 190;
                dtThongTinMang.Columns[2].Width = 190;
                dtThongTinMang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                ///
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
                txbHDMaKH.Format += (s, e) =>
                {
                    DataRowView row = (DataRowView)e.ListItem;
                    e.Value = $"{row["sHoTen"]} [{row["iMaKhachHang"]}]";
                };

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
        private void btnIn_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("D:\\Code\\Project\\NAM 3\\HSK\\BTL\\CrystalReport1.rpt");
            new FormReport(report).ShowDialog();
        }
       

        #region KhachHang

        private void dtThongTinKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Phương thức để làm rỗng các TextBox

        private void btnKHThem_Click(object sender, EventArgs e)
        {
             
            try
            {
                // Kiểm tra các trường nhập
                if (string.IsNullOrWhiteSpace(txbKHHoTen.Text))
                {
                    MessageBox.Show("Họ tên khách hàng không được để trống!");
                    txbKHHoTen.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbKHDiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ của khách hàng không được để trống!");
                    txbKHDiaChi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbKHSDT.Text))
                {
                    MessageBox.Show("SDT khách hàng không được để trống!");
                    txbKHSDT.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbKHEmail.Text))
                {
                    MessageBox.Show("Email khách hàng không được để trống!");
                    txbKHEmail.Focus();
                    return;
                }
                // Kiểm tra định dạng họ tên và địa chỉ
                if (!IsValidName(txbKHHoTen.Text))
                {
                    MessageBox.Show("Họ tên không hợp lệ!");
                    txbKHHoTen.Focus();
                    return;
                }
                if (!IsValidAddress(txbKHDiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ không hợp lệ!");
                    txbKHDiaChi.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txbKHSDT.Text))
                {
                    MessageBox.Show("SDT khách hàng không được để trống!");
                    txbKHSDT.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbKHEmail.Text))
                {
                    MessageBox.Show("Email khách hàng không được để trống!");
                    txbKHEmail.Focus();
                    return;
                }
                // Kiểm tra định dạng email và số điện thoại
                if (!IsValidEmail(txbKHEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    txbKHEmail.Focus();
                    return;
                }
                if (!IsValidPhoneNumber(txbKHSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    txbKHSDT.Focus();
                    return;
                }
                // Thêm dữ liệu vào cơ sở dữ liệu
                DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                    DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbKHHoTen.Text),
                    DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbKHSDT.Text),
                    DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbKHDiaChi.Text),
                    DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", txbKHEmail.Text));
                
                // Làm mới dữ liệu trong DataGridView
                dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");

                // Làm rỗng các TextBox sau khi thêm thành công
                ClearTextBoxes();

                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        } 
        private void XoaKhachHangTrongDatabase(string maKH)
        {
            string connectionString = "Data Source=LAPTOP-Q30JB24O\\SQLEXPRESS;Initial Catalog= QuanLyThuTienMang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tblKhachHang WHERE iMaKhachHang = @MaKH"; // Sửa lại theo đúng tên cột
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaKH", maKH);
                    cmd.ExecuteNonQuery();
                }
            }
        }
         
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dtThongTinKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            // Lấy hàng hiện tại được chọn
            DataGridViewRow selectedRow = dtThongTinKhachHang.CurrentRow;

            // Hiển thị thông tin lên các TextBox
            txbKHHoTen.Text = selectedRow.Cells["sHoTen"].Value.ToString();
            txbKHSDT.Text = selectedRow.Cells["sSoDienThoai"].Value.ToString();
            txbKHDiaChi.Text = selectedRow.Cells["sDiaChi"].Value.ToString();
            txbKHEmail.Text = selectedRow.Cells["sEmail"].Value.ToString();

            // Lưu mã khách hàng để sử dụng khi cập nhật
            currentMaKH = selectedRow.Cells["iMaKhachHang"].Value.ToString();
          

        }
         
        private void btnKHXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtThongTinKhachHang.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dtThongTinKhachHang.CurrentRow;
                string maKH = selectedRow.Cells["iMaKhachHang"].Value.ToString(); // Đảm bảo rằng cột này tồn tại và có tên chính xác
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XoaKhachHangTrongDatabase(maKH);
                    dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");
                    index = -1;
                    MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKHSuaLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường nhập có hợp lệ không
                if (string.IsNullOrWhiteSpace(txbKHHoTen.Text) ||
                    string.IsNullOrWhiteSpace(txbKHSDT.Text) ||
                    string.IsNullOrWhiteSpace(txbKHDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txbKHEmail.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tính hợp lệ của họ tên, số điện thoại, email
                if (!IsValidName(txbKHHoTen.Text))
                {
                    MessageBox.Show("Họ tên không hợp lệ!");
                    return;
                }
                if (!IsValidPhoneNumber(txbKHSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    return;
                }
                if (!IsValidEmail(txbKHEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    return;
                }

                // Cập nhật thông tin vào cơ sở dữ liệu
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbKHHoTen.Text);
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbKHSDT.Text);
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbKHDiaChi.Text);
                DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", txbKHEmail.Text);

                // Làm mới lại dữ liệu trong DataGridView
                dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");

                // Hiển thị thông báo
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa dữ liệu trong các TextBox
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ số hàng hợp lệ
            {
                
                // Kiểm tra xem có hàng nào được chọn hay không
                if (dtThongTinKhachHang.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (e.RowIndex >= 0)
                {
                    // Lấy hàng hiện tại được chọn
                    DataGridViewRow selectedRow = dtThongTinKhachHang.Rows[e.RowIndex];

                    // Hiển thị thông tin lên các TextBox
                    txbKHHoTen.Text = selectedRow.Cells["sHoTen"].Value.ToString();
                    txbKHSDT.Text = selectedRow.Cells["sSoDienThoai"].Value.ToString();
                    txbKHDiaChi.Text = selectedRow.Cells["sDiaChi"].Value.ToString();
                    txbKHEmail.Text = selectedRow.Cells["sEmail"].Value.ToString();

                    // Lưu mã khách hàng để sử dụng khi cập nhật
                    currentMaKH = selectedRow.Cells["iMaKhachHang"].Value.ToString();
                }  

                index = e.RowIndex; // Cập nhật chỉ số hàng
            }
                
        }
        private void LoadDataSource(string tableName, string filter)
        {
            // Thực hiện truy vấn và cập nhật lại DataGridView
            // ...
            dtThongTinKhachHang.DataSource = yourDataSource; // Đảm bảo rằng đây là dữ liệu mới nhất
        }
        private void dtThongTinKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dtThongTinKhachHang.SelectedRows.Count > 0)
            {
                index = dtThongTinKhachHang.SelectedRows[0].Index;
                MessageBox.Show($"Đã chọn khách hàng có chỉ số: {index}"); // Thông báo chỉ số đã chọn
            }
            else
            {
                index = -1;
            }
        }
        // Xoa khach hang
        #endregion




        #region NhanVien
        private void btnNVThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường nhập
                if (string.IsNullOrWhiteSpace(txbNVHoTen.Text))
                {
                    MessageBox.Show("Họ tên nhân viên không được để trống!");
                    txbNVHoTen.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbNVDiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ của nhân viên không được để trống!");
                    txbNVDiaChi.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbNVSDT.Text))
                {
                    MessageBox.Show("SDT nhân viên không được để trống!");
                    txbNVSDT.Focus();
                    return;
                }

                // Kiểm tra định dạng họ tên và địa chỉ
                if (!IsValidName(txbNVHoTen.Text))
                {
                    MessageBox.Show("Họ tên không hợp lệ!");
                    txbNVHoTen.Focus();
                    return;
                }
                if (!IsValidAddress(txbNVDiaChi.Text))
                {
                    MessageBox.Show("Địa chỉ không hợp lệ!");
                    txbNVDiaChi.Focus();
                    return;
                }
                if (!IsValidPhoneNumber(txbNVSDT.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    txbNVSDT.Focus();
                    return;
                }
                // Thêm dữ liệu vào cơ sở dữ liệu
                DBConnection.Instance.InsertDB("tblNhanVien",
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbNVHoTen.Text),
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbNVSDT.Text),
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbNVDiaChi.Text));

                // Làm mới dữ liệu trong DataGridView
              dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");

                // Làm rỗng các TextBox sau khi thêm thành công
                ClearTextBoxesNV();

                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtThongTinNhanVien.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dtThongTinNhanVien.CurrentRow;
                string maNV = selectedRow.Cells["iMaNhanVien"].Value.ToString(); // Đảm bảo rằng cột này tồn tại và có tên chính xác
                var result = MessageBox.Show("Bạn có  muốn xóa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    XoaNhanVienTrongDatabase(maNV);
                    dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");
                    index = -1;
                    MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaNhanVienTrongDatabase(string maNV)
        {
            string connectionString = "Data Source=LAPTOP-Q30JB24O\\SQLEXPRESS;Initial Catalog= QuanLyThuTienMang;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM tblNhanVien WHERE iMaNhanVien = @MaNV"; // Sửa lại theo đúng tên cột
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void dtThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpNhanVien_Click(object sender, EventArgs e)
        {

        }
        private void txbNVTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bindingSource = (BindingSource)dtThongTinCTHoaDon.DataSource;
                bindingSource.Filter = $"sHoTen LIKE '%{txbNVTim.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Hoa don

        private void dtThongTinHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dtThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtThongTinHoaDon.Columns["btnCTHoaDon"].Index && e.RowIndex >= 0)
            {
                new FormHoaDon().ShowDialog();
            }
        }


        #endregion


        #region Mang
        private void btnMThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường nhập
                if (string.IsNullOrWhiteSpace(txbMTenMang.Text))
                {
                    MessageBox.Show("Tên mạng không được để trống!");
                    txbMTenMang.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbMDonGia.Text))
                {
                    MessageBox.Show("Đơn giá không được để trống!");
                    txbMDonGia.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txbMMota.Text))
                {
                    MessageBox.Show("Mô tả không được để trống!");
                    txbMMota.Focus();
                    return;
                }

                // Kiểm tra định dạng họ tên và địa chỉ
                
                // Thêm dữ liệu vào cơ sở dữ liệu
                DBConnection.Instance.InsertDB("tblMang",
                DBConnection.Instance.BuildParameter("@sTenMang", SqlDbType.NVarChar, 100, "sTenMang", txbMTenMang.Text),
                DBConnection.Instance.BuildParameter("@sMoTa", SqlDbType.NVarChar, 15, "sMoTa", txbMMota.Text),
                DBConnection.Instance.BuildParameter("@iDonGia", SqlDbType.NVarChar, 255, "iDonGia", txbMDonGia.Text));

                // Làm mới dữ liệu trong DataGridView
                dtThongTinNhanVien.LoadDataSource("tblMang", "bDeleted=0");

                // Làm rỗng các TextBox sau khi thêm thành công
                ClearTextBoxesNV();

                MessageBox.Show("Thêm thông tin mạng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private void tpMang_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
