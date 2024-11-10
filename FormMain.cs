using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

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

                dgvThongTinHoaDon.LoadDataSource("vHoaDon");
                dgvThongTinHoaDon.Columns[0].HeaderText = "Mã HĐ";
                dgvThongTinHoaDon.Columns[1].HeaderText = "Mã KH";
                dgvThongTinHoaDon.Columns[2].HeaderText = "Mã NV";
                dgvThongTinHoaDon.Columns[3].HeaderText = "Ngày Tạo";
                dgvThongTinHoaDon.Columns[4].HeaderText = "Tổng tiền";

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnCTHoaDon";
                btnColumn.HeaderText = "CT Hóa Đơn";
                btnColumn.Text = "Xem";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvThongTinHoaDon.Columns.Add(btnColumn);

                dgvThongTinHoaDon.Columns[0].Width = 120;
                dgvThongTinHoaDon.Columns[1].Width = 120;
                dgvThongTinHoaDon.Columns[2].Width = 120;
                dgvThongTinHoaDon.Columns[3].Width = 150;
                dgvThongTinHoaDon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvThongTinHoaDon.Columns[4].SetFormatMoneys();

                dgvThongTinCTHoaDon.LoadDataSource("vChiTietHoaDon");
                dgvThongTinCTHoaDon.Columns[0].HeaderText = "Mã CT Hóa Đơn";
                dgvThongTinCTHoaDon.Columns[1].HeaderText = "Mã Hóa Đơn";
                dgvThongTinCTHoaDon.Columns[2].HeaderText = "Tên Mạng";
                dgvThongTinCTHoaDon.Columns[3].HeaderText = "Đơn giá";
                dgvThongTinCTHoaDon.Columns[4].HeaderText = "Số tháng đăng ký";
                dgvThongTinCTHoaDon.Columns[5].HeaderText = "Thành tiền";

                dgvThongTinCTHoaDon.Columns[0].Width = 100;
                dgvThongTinCTHoaDon.Columns[1].Width = 100;
                dgvThongTinCTHoaDon.Columns[2].Width = 100;
                dgvThongTinCTHoaDon.Columns[3].Width = 150;
                dgvThongTinCTHoaDon.Columns[4].Width = 150;
                dgvThongTinCTHoaDon.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvThongTinCTHoaDon.Columns[3].SetFormatMoneys();
                dgvThongTinCTHoaDon.Columns[5].SetFormatMoneys();

                dtThongTinMang.LoadDataSource("tblMang", "bDeleted=0");
                dtThongTinMang.Columns[0].HeaderText = "Mã Mạng";
                dtThongTinMang.Columns[1].HeaderText = "Tên Mạng";
                dtThongTinMang.Columns[2].HeaderText = "Mô Tả";
                dtThongTinMang.Columns[3].HeaderText = "Đơn giá";

                dtThongTinMang.Columns[0].Width = 150;
                dtThongTinMang.Columns[1].Width = 190;
                dtThongTinMang.Columns[2].Width = 190;
                dtThongTinMang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dtThongTinMang.Columns[3].SetFormatMoneys();

                cboHDMaNV.LoadDataSource("tblNhanVien", "sHoTen", "iMaNhanVien");

                cboHDMaKH.LoadDataSource("tblKhachHang", "sHoTen", "iMaKhachHang");

                cboCTHDMaHD.LoadDataSource("tblHoaDon", "iMaHoaDon", "iMaHoaDon");

                cboCTHDMaMang.LoadDataSource("tblMang", "sTenMang", "iMaMang");

                lblTimHD.Text = $"Tìm thấy : 0/{dgvThongTinHoaDon.Rows.Count}";
                lblTimCTHD.Text = $"Tìm thấy : 0/{dgvThongTinCTHoaDon.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #region KhachHang

        private void dtThongTinKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Phương thức để làm rỗng các TextBox

        private void btnKHThem_Click(object sender, EventArgs e)
        {
            if (this.TextIsNullOrEmpty(txbKHHoTen, txbKHDiaChi, txbKHSDT, txbKHEmail, txbKHSDT, txbKHEmail)) return;

            // Kiểm tra định dạng họ tên và địa chỉ
            if (!txbKHHoTen.Text.IsValidName())
            {
                MessageBox.Show("Họ tên không hợp lệ!");
                txbKHHoTen.Focus();
                return;
            }
            if (!txbKHDiaChi.Text.IsValidAddress())
            {
                MessageBox.Show("Địa chỉ không hợp lệ!");
                txbKHDiaChi.Focus();
                return;
            }

            // Kiểm tra định dạng email và số điện thoại
            if (!txbKHEmail.Text.IsValidEmail())
            {
                MessageBox.Show("Email không hợp lệ!");
                txbKHEmail.Focus();
                return;
            }
            if (!txbKHSDT.Text.IsValidPhoneNumber())
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txbKHSDT.Focus();
                return;
            }
            try
            {
                // Thêm dữ liệu vào cơ sở dữ liệu
                if (DBConnection.Instance.InsertDB("tblKhachHang", "sp_ThemKhachHang",
                    DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbKHHoTen.Text),
                    DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbKHSDT.Text),
                    DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbKHDiaChi.Text),
                    DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", txbKHEmail.Text)))
                {
                    // Làm mới dữ liệu trong DataGridView
                    dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");

                    // Làm rỗng các TextBox sau khi thêm thành công
                    ClearTextBoxes();

                    MessageBox.Show("Thêm khách hàng thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
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

        private void btnKHSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtThongTinKhachHang.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dtThongTinKhachHang.CurrentRow;
                string maKH = selectedRow.Cells["iMaKhachHang"].Value.ToString();
                var result = MessageBox.Show("Bạn có  muốn sửa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DBConnection.Instance.UpdateDB("tblKhachHang",
                    DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", maKH),
                    DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbKHHoTen.Text),
                    DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbKHSDT.Text),
                    DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbKHDiaChi.Text),
                    DBConnection.Instance.BuildParameter("@sEmail", SqlDbType.NVarChar, 100, "sEmail", txbKHEmail.Text));

                    DBConnection.Instance.SelectDB("tblKhachHang");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (DBConnection.Instance.DeleteDB("tblKhachHang", DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", maKH)))
                    {
                        dtThongTinKhachHang.LoadDataSource("tblKhachHang", "bDeleted=0");
                        index = -1;
                        MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                dtThongTinKhachHang.LoadDataSource("tblKhachHang");

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
            if (this.TextIsNullOrEmpty(txbNVHoTen, txbNVDiaChi, txbNVSDT, txbNVHoTen, txbNVDiaChi, txbNVSDT)) return;
            try
            {
                // Thêm dữ liệu vào cơ sở dữ liệu
                if (DBConnection.Instance.InsertDB("tblNhanVien",
                DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbNVHoTen.Text),
                DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbNVSDT.Text),
                DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbNVDiaChi.Text)))
                {
                    // Làm mới dữ liệu trong DataGridView
                    dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");

                    // Làm rỗng các TextBox sau khi thêm thành công
                    ClearTextBoxesNV();

                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnNVSua_Click(object sender, EventArgs e)
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
                var result = MessageBox.Show("Bạn có  muốn sửa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DBConnection.Instance.UpdateDB("tblNhanVien",
                    DBConnection.Instance.BuildParameter("@iMaNhanVien", SqlDbType.Int, 0, "iMaNhanVien", maNV),
                    DBConnection.Instance.BuildParameter("@sHoTen", SqlDbType.NVarChar, 100, "sHoTen", txbNVHoTen.Text),
                    DBConnection.Instance.BuildParameter("@sSoDienThoai", SqlDbType.NVarChar, 15, "sSoDienThoai", txbNVSDT.Text),
                    DBConnection.Instance.BuildParameter("@sDiaChi", SqlDbType.NVarChar, 255, "sDiaChi", txbNVDiaChi.Text));

                    DBConnection.Instance.SelectDB("tblNhanVien");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (DBConnection.Instance.DeleteDB("tblNhanVien", DBConnection.Instance.BuildParameter("@iMaNhanVien", SqlDbType.Int, 0, "iMaNhanVien", maNV)))
                    {
                        dtThongTinNhanVien.LoadDataSource("tblNhanVien", "bDeleted=0");
                        index = -1;
                        MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                BindingSource bindingSource = (BindingSource)dgvThongTinHoaDon.DataSource;
                bindingSource.Filter = $"sHoTen LIKE '%{txbNVTim.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Hóa Đơn và Chi Tiết Hóa Đơn [Dũng]

        private void btnIn_Click(object sender, EventArgs e)
        {
            var table = (dgvThongTinHoaDon.DataSource as DataView).Table;
            var row = table.Rows[dgvThongTinHoaDon.CurrentRow.Index];
            new FormReport(row.Field<int>("iMaHoaDon")).ShowDialog();
        }

        private void dtThongTinHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (e.ColumnIndex == dgv.Columns["btnCTHoaDon"].Index && e.RowIndex >= 0)
            {
                var table = dgv.DataSource as DataView;
                new FormHoaDon(table.Table.Rows[e.RowIndex].Field<int>("iMaHoaDon")).ShowDialog();
            }
        }

        private void btnHDThem_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Instance.InsertDB("tblHoaDon", "sp_ThemHoaDon",
                DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", cboHDMaKH.SelectedValue),
                DBConnection.Instance.BuildParameter("@iMaNhanVien", SqlDbType.Int, 0, "iMaNhanVien", cboHDMaNV.SelectedValue),
                DBConnection.Instance.BuildParameter("@dNgayTao", SqlDbType.Date, 0, "dNgayTao", dtpNgayTaoHD.Value));

                var table = DBConnection.Instance.SelectDB("tblHoaDon", "bDeleted=0");

                new FormHoaDon(table.Rows[table.Rows.Count - 1].Field<int>("iMaHoaDon")).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDSua_Click(object sender, EventArgs e)
        {
            var table = (dgvThongTinHoaDon.DataSource as DataView).Table;
            try
            {
                var row = table.Rows[dgvThongTinHoaDon.CurrentRow.Index];
                DBConnection.Instance.UpdateDB("tblHoaDon",
                DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", row.Field<int>("iMaHoaDon")),
                DBConnection.Instance.BuildParameter("@iMaKhachHang", SqlDbType.Int, 0, "iMaKhachHang", cboHDMaKH.SelectedValue),
                DBConnection.Instance.BuildParameter("@iMaNhanVien", SqlDbType.Int, 0, "iMaNhanVien", cboHDMaNV.SelectedValue),
                DBConnection.Instance.BuildParameter("@dNgayTao", SqlDbType.Date, 0, "dNgayTao", dtpNgayTaoHD.Value));

                DBConnection.Instance.SelectDB("vHoaDon");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHDXoa_Click(object sender, EventArgs e)
        {
            var table = (dgvThongTinHoaDon.DataSource as DataView).Table;
            try
            {
                var row = table.Rows[dgvThongTinHoaDon.CurrentRow.Index];
                DBConnection.Instance.DeleteDB("tblHoaDon",
                DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", row.Field<int>("iMaHoaDon")));
                DBConnection.Instance.SelectDB("vHoaDon");
                DBConnection.Instance.SelectDB("vChiTietHoaDon");
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
                cboHDMaKH.SelectedValue = row.Field<int>("iMaKhachHang");
                cboHDMaNV.SelectedValue = row.Field<int>("iMaNhanVien");
                dtpNgayTaoHD.Value = row.Field<DateTime>("dNgayTao");
            }
        }


        private void dtpNgayTim_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = dgvThongTinHoaDon.DataSource as DataView;
                dataView.AddRowFilter($"dNgayTao < '{dtpNgayTimHD.Value.ToString("dd/MM/yyyy")}'");

                lblTimHD.Text = $"Tìm thấy : {dataView.Count}/{DBConnection.Instance.DataSet.Tables["vHoaDon"].Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboHDMaKH_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView row = (DataRowView)e.ListItem;
            e.Value = $"{row["sHoTen"]} [{row["iMaKhachHang"]}]";
        }

        private void cboHDMaNV_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView row = (DataRowView)e.ListItem;
            e.Value = $"{row["sHoTen"]} [{row["iMaNhanVien"]}]";
        }

        private void dgvThongTinCTHoaDon_CurrentCellChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            var table = (dgv.DataSource as DataView).Table;
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                var row = table.Rows[dgv.CurrentRow.Index];
                var selectedMang = cboCTHDMaMang.Items.Cast<DataRowView>().FirstOrDefault(item => item["sTenMang"].ToString() == row.Field<string>("sTenMang"));
                cboCTHDMaHD.SelectedValue = row.Field<int>("iMaHoaDon");
                cboCTHDMaMang.SelectedValue = selectedMang["iMaMang"];
                txtCTHDSoThangDK.Text = row.Field<int>("iSoThangDangKy").ToString();
            }
        }

        private void btnCTHDThem_Click(object sender, EventArgs e)
        {
            if (this.TextIsNullOrEmpty(txtCTHDSoThangDK)) return;
            if (int.TryParse(txtCTHDSoThangDK.Text, out int result))
            {
                var table = (dgvThongTinHoaDon.DataSource as DataView).Table;
                try
                {
                    DBConnection.Instance.InsertDB("tblChiTietHoaDon", "sp_ThemChiTietHoaDon",
                    DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", cboCTHDMaHD.SelectedValue),
                    DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", cboCTHDMaMang.SelectedValue),
                    DBConnection.Instance.BuildParameter("@iSoThangDangKy", SqlDbType.Int, 0, "iSoThangDangKy", result));

                    DBConnection.Instance.SelectDB("vChiTietHoaDon");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Điền vào là số");
            }
        }

        private void btnCTHDSua_Click(object sender, EventArgs e)
        {
            if (this.TextIsNullOrEmpty(txtCTHDSoThangDK)) return;
            if (int.TryParse(txtCTHDSoThangDK.Text, out int result))
            {
                var table = (dgvThongTinCTHoaDon.DataSource as DataView).Table;
                try
                {
                    var row = table.Rows[dgvThongTinCTHoaDon.CurrentRow.Index];
                    DBConnection.Instance.UpdateDB("tblChiTietHoaDon",
                    DBConnection.Instance.BuildParameter("@iMaChiTietHD", SqlDbType.Int, 0, "iMaChiTietHD", row.Field<int>("iMaChiTietHD")),
                    DBConnection.Instance.BuildParameter("@iMaHoaDon", SqlDbType.Int, 0, "iMaHoaDon", cboCTHDMaHD.SelectedValue),
                    DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", cboCTHDMaMang.SelectedValue),
                    DBConnection.Instance.BuildParameter("@iSoThangDangKy", SqlDbType.Int, 0, "iSoThangDangKy", result));

                    DBConnection.Instance.SelectDB("vChiTietHoaDon");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Điền vào là số");
            }
        }

        private void btnCTHDXoa_Click(object sender, EventArgs e)
        {
            var table = (dgvThongTinHoaDon.DataSource as DataView).Table;
            try
            {
                var row = table.Rows[dgvThongTinHoaDon.CurrentRow.Index];
                DBConnection.Instance.DeleteDB("tblChiTietHoaDon",
                DBConnection.Instance.BuildParameter("@iMaChiTietHD", SqlDbType.Int, 0, "iMaChiTietHD", row.Field<int>("iMaChiTietHD")));

                DBConnection.Instance.SelectDB("vChiTietHoaDon");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbCTHDTim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dataView = dgvThongTinCTHoaDon.DataSource as DataView;
                dataView.AddRowFilter($"sTenMang LIKE '%{txbCTHDTim.Text}%'");

                lblTimCTHD.Text = $"Tìm thấy : {dataView.Count}/{DBConnection.Instance.DataSet.Tables["vChiTietHoaDon"].Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtCTHDSoThangDK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cboCTHDMaMang_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView row = (DataRowView)e.ListItem;
            e.Value = $"{row["sTenMang"]} [{row["iMaMang"]}]";
        }
        #endregion

        #region Mang
        private void btnMThem_Click(object sender, EventArgs e)
        {
            if (this.TextIsNullOrEmpty(txbMTenMang, txbMDonGia, txbMMota)) return;

            try
            {
                // Kiểm tra định dạng họ tên và địa chỉ

                // Thêm dữ liệu vào cơ sở dữ liệu
                if (DBConnection.Instance.InsertDB("tblMang",
                DBConnection.Instance.BuildParameter("@sTenMang", SqlDbType.NVarChar, 100, "sTenMang", txbMTenMang.Text),
                DBConnection.Instance.BuildParameter("@sMoTa", SqlDbType.NVarChar, 15, "sMoTa", txbMMota.Text),
                DBConnection.Instance.BuildParameter("@iDonGia", SqlDbType.NVarChar, 255, "iDonGia", txbMDonGia.Text)))
                {
                    MessageBox.Show("Thêm thông tin mạng thành công!");

                    // Làm mới dữ liệu trong DataGridView
                    DBConnection.Instance.SelectDB("tblMang", "bDeleted=0");

                }
                else
                {
                    MessageBox.Show("Thêm thông tin mạng không thành công!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void btnMSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtThongTinMang.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dtThongTinMang.CurrentRow;
                string maKH = selectedRow.Cells["iMaMang"].Value.ToString();
                var result = MessageBox.Show("Bạn có  muốn sửa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DBConnection.Instance.UpdateDB("tblMang",
                    DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", maKH),
                    DBConnection.Instance.BuildParameter("@sTenMang", SqlDbType.NVarChar, 100, "sTenMang", txbMTenMang.Text),
                    DBConnection.Instance.BuildParameter("@sMoTa", SqlDbType.NVarChar, 255, "sMoTa", txbMMota.Text),
                    DBConnection.Instance.BuildParameter("@iDonGia", SqlDbType.Int, 0, "iDonGia", txbMDonGia.Text));

                    DBConnection.Instance.SelectDB("tblMang", "bDeleted=0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtThongTinMang.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dtThongTinMang.CurrentRow;
                string maMang = selectedRow.Cells["iMaMang"].Value.ToString(); // Đảm bảo rằng cột này tồn tại và có tên chính xác
                var result = MessageBox.Show("Bạn có  muốn xóa nhân viên này không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (DBConnection.Instance.DeleteDB("tblMang", DBConnection.Instance.BuildParameter("@iMaMang", SqlDbType.Int, 0, "iMaMang", maMang)))
                    {
                        DBConnection.Instance.SelectDB("tblMang", "bDeleted=0");
                        index = -1;
                        MessageBox.Show("Khách hàng đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMTim_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource bindingSource = (BindingSource)dtThongTinMang.DataSource;
                bindingSource.Filter = $"sTenMang LIKE '%{txbMtim.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tpMang_Click(object sender, EventArgs e)
        {

        }


        private void dtThongTinMang_CurrentCellChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            var table = (dgv.DataSource as DataView).Table;
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                var row = table.Rows[dgv.CurrentRow.Index];
                txbMTenMang.Text = row.Field<string>("sTenMang");
                txbMDonGia.Text = row.Field<int>("iDonGia").ToString();
                txbMMota.Text = row.Field<string>("sMoTa");
            }
        }
        #endregion

        private void dtThongTinKhachHang_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void dtThongTinNhanVien_CurrentCellChanged(object sender, EventArgs e)
        {
            var dgv = sender as DataGridView;
            var table = (dgv.DataSource as DataView).Table;
            if (dgv.CurrentRow != null && dgv.CurrentRow.Index >= 0)
            {
                var row = table.Rows[dgv.CurrentRow.Index];
                txbNVHoTen.Text = row.Field<string>("sHoTen");
                txbNVDiaChi.Text = row.Field<string>("sDiaChi");
                txbNVSDT.Text = row.Field<string>("sSoDienThoai");
            }
        }
    }
}
