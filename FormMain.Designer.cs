using System.Windows.Forms;

namespace BTL
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label17 = new System.Windows.Forms.Label();
            this.txbCTHDTim = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbMTenMang = new System.Windows.Forms.TextBox();
            this.dtpNgayTaoHD = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCTHDThoat = new System.Windows.Forms.Button();
            this.btnCTHDXoa = new System.Windows.Forms.Button();
            this.btnCTHDSua = new System.Windows.Forms.Button();
            this.btnCTHDThem = new System.Windows.Forms.Button();
            this.txtCTHDSoThangDK = new System.Windows.Forms.TextBox();
            this.tpChiTietHoaDon = new System.Windows.Forms.TabPage();
            this.lblTimCTHD = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cboCTHDMaMang = new System.Windows.Forms.ComboBox();
            this.cboCTHDMaHD = new System.Windows.Forms.ComboBox();
            this.dgvThongTinCTHoaDon = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txbMtim = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnMThoat = new System.Windows.Forms.Button();
            this.btnMTim = new System.Windows.Forms.Button();
            this.btnMXoa = new System.Windows.Forms.Button();
            this.btnMSua = new System.Windows.Forms.Button();
            this.btnMThem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txbMMota = new System.Windows.Forms.TextBox();
            this.txbMDonGia = new System.Windows.Forms.TextBox();
            this.tpMang = new System.Windows.Forms.TabPage();
            this.dtThongTinMang = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnNVMo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbNVTim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNVThoat = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVSua = new System.Windows.Forms.Button();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.txbNVDiaChi = new System.Windows.Forms.TextBox();
            this.txbNVSDT = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpNhanVien = new System.Windows.Forms.TabPage();
            this.txbNVHoTen = new System.Windows.Forms.TextBox();
            this.dtThongTinNhanVien = new System.Windows.Forms.DataGridView();
            this.tpKhachHang = new System.Windows.Forms.TabPage();
            this.btnKHSuaLuu = new System.Windows.Forms.Button();
            this.dtThongTinKhachHang = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbKHEmail = new System.Windows.Forms.TextBox();
            this.txbKHDiaChi = new System.Windows.Forms.TextBox();
            this.txbKHSDT = new System.Windows.Forms.TextBox();
            this.txbKHHoTen = new System.Windows.Forms.TextBox();
            this.btnKHThoat = new System.Windows.Forms.Button();
            this.btnKHThem = new System.Windows.Forms.Button();
            this.txbKHTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKHXoa = new System.Windows.Forms.Button();
            this.btnKHSua = new System.Windows.Forms.Button();
            this.tpHoaDon = new System.Windows.Forms.TabPage();
            this.lblTimHD = new System.Windows.Forms.Label();
            this.dtpNgayTimHD = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.cboHDMaKH = new System.Windows.Forms.ComboBox();
            this.cboHDMaNV = new System.Windows.Forms.ComboBox();
            this.dgvThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.btnHDThoat = new System.Windows.Forms.Button();
            this.btnHDIn = new System.Windows.Forms.Button();
            this.btnHDXoa = new System.Windows.Forms.Button();
            this.btnHDSua = new System.Windows.Forms.Button();
            this.btnHDThem = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tpChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTHoaDon)).BeginInit();
            this.tpMang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinMang)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinNhanVien)).BeginInit();
            this.tpKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinKhachHang)).BeginInit();
            this.tpHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(361, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ngày tạo HD:";
            // 
            // txbCTHDTim
            // 
            this.txbCTHDTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCTHDTim.Location = new System.Drawing.Point(537, 247);
            this.txbCTHDTim.Multiline = true;
            this.txbCTHDTim.Name = "txbCTHDTim";
            this.txbCTHDTim.Size = new System.Drawing.Size(126, 35);
            this.txbCTHDTim.TabIndex = 32;
            this.txbCTHDTim.TextChanged += new System.EventHandler(this.txbCTHDTim_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(430, 80);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 20);
            this.label20.TabIndex = 31;
            this.label20.Text = "Số tháng đăng ký:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(58, 162);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 30;
            this.label19.Text = "Mã Mạng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(58, 80);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 29;
            this.label18.Text = "Mã HĐ:";
            // 
            // txbMTenMang
            // 
            this.txbMTenMang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMTenMang.Location = new System.Drawing.Point(131, 88);
            this.txbMTenMang.Margin = new System.Windows.Forms.Padding(2);
            this.txbMTenMang.Multiline = true;
            this.txbMTenMang.Name = "txbMTenMang";
            this.txbMTenMang.Size = new System.Drawing.Size(145, 29);
            this.txbMTenMang.TabIndex = 19;
            // 
            // dtpNgayTaoHD
            // 
            this.dtpNgayTaoHD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTaoHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTaoHD.Location = new System.Drawing.Point(481, 81);
            this.dtpNgayTaoHD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTaoHD.Name = "dtpNgayTaoHD";
            this.dtpNgayTaoHD.Size = new System.Drawing.Size(124, 26);
            this.dtpNgayTaoHD.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(36, 162);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Mã NV:";
            // 
            // btnCTHDThoat
            // 
            this.btnCTHDThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnCTHDThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDThoat.Location = new System.Drawing.Point(700, 254);
            this.btnCTHDThoat.Name = "btnCTHDThoat";
            this.btnCTHDThoat.Size = new System.Drawing.Size(90, 28);
            this.btnCTHDThoat.TabIndex = 27;
            this.btnCTHDThoat.Text = "Thoát";
            this.btnCTHDThoat.UseVisualStyleBackColor = false;
            // 
            // btnCTHDXoa
            // 
            this.btnCTHDXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnCTHDXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDXoa.Location = new System.Drawing.Point(248, 254);
            this.btnCTHDXoa.Name = "btnCTHDXoa";
            this.btnCTHDXoa.Size = new System.Drawing.Size(90, 28);
            this.btnCTHDXoa.TabIndex = 25;
            this.btnCTHDXoa.Text = "Xóa";
            this.btnCTHDXoa.UseVisualStyleBackColor = false;
            this.btnCTHDXoa.Click += new System.EventHandler(this.btnCTHDXoa_Click);
            // 
            // btnCTHDSua
            // 
            this.btnCTHDSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnCTHDSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDSua.Location = new System.Drawing.Point(152, 254);
            this.btnCTHDSua.Name = "btnCTHDSua";
            this.btnCTHDSua.Size = new System.Drawing.Size(90, 28);
            this.btnCTHDSua.TabIndex = 24;
            this.btnCTHDSua.Text = "Sửa";
            this.btnCTHDSua.UseVisualStyleBackColor = false;
            this.btnCTHDSua.Click += new System.EventHandler(this.btnCTHDSua_Click);
            // 
            // btnCTHDThem
            // 
            this.btnCTHDThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnCTHDThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCTHDThem.Location = new System.Drawing.Point(56, 254);
            this.btnCTHDThem.Name = "btnCTHDThem";
            this.btnCTHDThem.Size = new System.Drawing.Size(90, 28);
            this.btnCTHDThem.TabIndex = 23;
            this.btnCTHDThem.Text = "Thêm";
            this.btnCTHDThem.UseVisualStyleBackColor = false;
            this.btnCTHDThem.Click += new System.EventHandler(this.btnCTHDThem_Click);
            // 
            // txtCTHDSoThangDK
            // 
            this.txtCTHDSoThangDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCTHDSoThangDK.Location = new System.Drawing.Point(590, 72);
            this.txtCTHDSoThangDK.Margin = new System.Windows.Forms.Padding(2);
            this.txtCTHDSoThangDK.Multiline = true;
            this.txtCTHDSoThangDK.Name = "txtCTHDSoThangDK";
            this.txtCTHDSoThangDK.Size = new System.Drawing.Size(145, 29);
            this.txtCTHDSoThangDK.TabIndex = 21;
            this.txtCTHDSoThangDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCTHDSoThangDK_KeyPress);
            // 
            // tpChiTietHoaDon
            // 
            this.tpChiTietHoaDon.Controls.Add(this.lblTimCTHD);
            this.tpChiTietHoaDon.Controls.Add(this.label26);
            this.tpChiTietHoaDon.Controls.Add(this.cboCTHDMaMang);
            this.tpChiTietHoaDon.Controls.Add(this.cboCTHDMaHD);
            this.tpChiTietHoaDon.Controls.Add(this.dgvThongTinCTHoaDon);
            this.tpChiTietHoaDon.Controls.Add(this.txbCTHDTim);
            this.tpChiTietHoaDon.Controls.Add(this.label20);
            this.tpChiTietHoaDon.Controls.Add(this.label19);
            this.tpChiTietHoaDon.Controls.Add(this.label18);
            this.tpChiTietHoaDon.Controls.Add(this.btnCTHDThoat);
            this.tpChiTietHoaDon.Controls.Add(this.btnCTHDXoa);
            this.tpChiTietHoaDon.Controls.Add(this.btnCTHDSua);
            this.tpChiTietHoaDon.Controls.Add(this.btnCTHDThem);
            this.tpChiTietHoaDon.Controls.Add(this.txtCTHDSoThangDK);
            this.tpChiTietHoaDon.Controls.Add(this.label13);
            this.tpChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpChiTietHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tpChiTietHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.tpChiTietHoaDon.Name = "tpChiTietHoaDon";
            this.tpChiTietHoaDon.Size = new System.Drawing.Size(851, 582);
            this.tpChiTietHoaDon.TabIndex = 3;
            this.tpChiTietHoaDon.Text = "Chi Tiết Hóa Đơn";
            this.tpChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // lblTimCTHD
            // 
            this.lblTimCTHD.AutoSize = true;
            this.lblTimCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimCTHD.Location = new System.Drawing.Point(534, 285);
            this.lblTimCTHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimCTHD.Name = "lblTimCTHD";
            this.lblTimCTHD.Size = new System.Drawing.Size(74, 16);
            this.lblTimCTHD.TabIndex = 39;
            this.lblTimCTHD.Text = "Tìm thấy :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(374, 254);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(158, 20);
            this.label26.TabIndex = 37;
            this.label26.Text = "Tìm theo tên mạng";
            // 
            // cboCTHDMaMang
            // 
            this.cboCTHDMaMang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCTHDMaMang.FormattingEnabled = true;
            this.cboCTHDMaMang.Location = new System.Drawing.Point(150, 159);
            this.cboCTHDMaMang.Name = "cboCTHDMaMang";
            this.cboCTHDMaMang.Size = new System.Drawing.Size(205, 28);
            this.cboCTHDMaMang.TabIndex = 36;
            // 
            // cboCTHDMaHD
            // 
            this.cboCTHDMaHD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCTHDMaHD.FormattingEnabled = true;
            this.cboCTHDMaHD.Location = new System.Drawing.Point(152, 71);
            this.cboCTHDMaHD.Name = "cboCTHDMaHD";
            this.cboCTHDMaHD.Size = new System.Drawing.Size(205, 28);
            this.cboCTHDMaHD.TabIndex = 35;
            // 
            // dgvThongTinCTHoaDon
            // 
            this.dgvThongTinCTHoaDon.AllowUserToAddRows = false;
            this.dgvThongTinCTHoaDon.AllowUserToDeleteRows = false;
            this.dgvThongTinCTHoaDon.AllowUserToResizeColumns = false;
            this.dgvThongTinCTHoaDon.AllowUserToResizeRows = false;
            this.dgvThongTinCTHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThongTinCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinCTHoaDon.Location = new System.Drawing.Point(0, 324);
            this.dgvThongTinCTHoaDon.Name = "dgvThongTinCTHoaDon";
            this.dgvThongTinCTHoaDon.ReadOnly = true;
            this.dgvThongTinCTHoaDon.RowHeadersVisible = false;
            this.dgvThongTinCTHoaDon.RowHeadersWidth = 51;
            this.dgvThongTinCTHoaDon.Size = new System.Drawing.Size(851, 258);
            this.dgvThongTinCTHoaDon.TabIndex = 34;
            this.dgvThongTinCTHoaDon.CurrentCellChanged += new System.EventHandler(this.dgvThongTinCTHoaDon_CurrentCellChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(2, 297);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(266, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Danh sách chi tiết háo đơn:";
            // 
            // txbMtim
            // 
            this.txbMtim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMtim.Location = new System.Drawing.Point(548, 256);
            this.txbMtim.Multiline = true;
            this.txbMtim.Name = "txbMtim";
            this.txbMtim.Size = new System.Drawing.Size(126, 33);
            this.txbMtim.TabIndex = 33;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(440, 142);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 20);
            this.label23.TabIndex = 32;
            this.label23.Text = "Mô tả:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(41, 183);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 20);
            this.label22.TabIndex = 31;
            this.label22.Text = "Đơn giá:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(37, 96);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 20);
            this.label21.TabIndex = 30;
            this.label21.Text = "Tên mạng:";
            // 
            // btnMThoat
            // 
            this.btnMThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnMThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMThoat.Location = new System.Drawing.Point(702, 256);
            this.btnMThoat.Name = "btnMThoat";
            this.btnMThoat.Size = new System.Drawing.Size(90, 28);
            this.btnMThoat.TabIndex = 29;
            this.btnMThoat.Text = "Thoát";
            this.btnMThoat.UseVisualStyleBackColor = false;
            // 
            // btnMTim
            // 
            this.btnMTim.BackColor = System.Drawing.Color.DarkGray;
            this.btnMTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMTim.Location = new System.Drawing.Point(444, 256);
            this.btnMTim.Name = "btnMTim";
            this.btnMTim.Size = new System.Drawing.Size(90, 28);
            this.btnMTim.TabIndex = 28;
            this.btnMTim.Text = "Tìm";
            this.btnMTim.UseVisualStyleBackColor = false;
            // 
            // btnMXoa
            // 
            this.btnMXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnMXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMXoa.Location = new System.Drawing.Point(310, 256);
            this.btnMXoa.Name = "btnMXoa";
            this.btnMXoa.Size = new System.Drawing.Size(90, 28);
            this.btnMXoa.TabIndex = 27;
            this.btnMXoa.Text = "Xóa";
            this.btnMXoa.UseVisualStyleBackColor = false;
            // 
            // btnMSua
            // 
            this.btnMSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnMSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSua.Location = new System.Drawing.Point(170, 256);
            this.btnMSua.Name = "btnMSua";
            this.btnMSua.Size = new System.Drawing.Size(90, 28);
            this.btnMSua.TabIndex = 26;
            this.btnMSua.Text = "Sửa";
            this.btnMSua.UseVisualStyleBackColor = false;
            // 
            // btnMThem
            // 
            this.btnMThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnMThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMThem.Location = new System.Drawing.Point(40, 256);
            this.btnMThem.Name = "btnMThem";
            this.btnMThem.Size = new System.Drawing.Size(90, 28);
            this.btnMThem.TabIndex = 25;
            this.btnMThem.Text = "Thêm";
            this.btnMThem.UseVisualStyleBackColor = false;
            this.btnMThem.Click += new System.EventHandler(this.btnMThem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 297);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(247, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "Danh sách các gói mạng:";
            // 
            // txbMMota
            // 
            this.txbMMota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMMota.Location = new System.Drawing.Point(525, 115);
            this.txbMMota.Margin = new System.Windows.Forms.Padding(2);
            this.txbMMota.Multiline = true;
            this.txbMMota.Name = "txbMMota";
            this.txbMMota.Size = new System.Drawing.Size(177, 70);
            this.txbMMota.TabIndex = 21;
            // 
            // txbMDonGia
            // 
            this.txbMDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMDonGia.Location = new System.Drawing.Point(131, 175);
            this.txbMDonGia.Margin = new System.Windows.Forms.Padding(2);
            this.txbMDonGia.Multiline = true;
            this.txbMDonGia.Name = "txbMDonGia";
            this.txbMDonGia.Size = new System.Drawing.Size(145, 29);
            this.txbMDonGia.TabIndex = 20;
            // 
            // tpMang
            // 
            this.tpMang.Controls.Add(this.dtThongTinMang);
            this.tpMang.Controls.Add(this.txbMtim);
            this.tpMang.Controls.Add(this.label23);
            this.tpMang.Controls.Add(this.label22);
            this.tpMang.Controls.Add(this.label21);
            this.tpMang.Controls.Add(this.btnMThoat);
            this.tpMang.Controls.Add(this.btnMTim);
            this.tpMang.Controls.Add(this.btnMXoa);
            this.tpMang.Controls.Add(this.btnMSua);
            this.tpMang.Controls.Add(this.btnMThem);
            this.tpMang.Controls.Add(this.label14);
            this.tpMang.Controls.Add(this.txbMMota);
            this.tpMang.Controls.Add(this.txbMDonGia);
            this.tpMang.Controls.Add(this.txbMTenMang);
            this.tpMang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpMang.Location = new System.Drawing.Point(4, 22);
            this.tpMang.Margin = new System.Windows.Forms.Padding(2);
            this.tpMang.Name = "tpMang";
            this.tpMang.Size = new System.Drawing.Size(851, 582);
            this.tpMang.TabIndex = 4;
            this.tpMang.Text = "Mạng";
            this.tpMang.UseVisualStyleBackColor = true;
            this.tpMang.Click += new System.EventHandler(this.tpMang_Click);
            // 
            // dtThongTinMang
            // 
            this.dtThongTinMang.AllowUserToAddRows = false;
            this.dtThongTinMang.AllowUserToDeleteRows = false;
            this.dtThongTinMang.AllowUserToResizeColumns = false;
            this.dtThongTinMang.AllowUserToResizeRows = false;
            this.dtThongTinMang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtThongTinMang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongTinMang.Location = new System.Drawing.Point(0, 329);
            this.dtThongTinMang.Name = "dtThongTinMang";
            this.dtThongTinMang.ReadOnly = true;
            this.dtThongTinMang.RowHeadersVisible = false;
            this.dtThongTinMang.RowHeadersWidth = 51;
            this.dtThongTinMang.Size = new System.Drawing.Size(851, 253);
            this.dtThongTinMang.TabIndex = 35;
            this.dtThongTinMang.CurrentCellChanged += new System.EventHandler(this.dtThongTinMang_CurrentCellChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mã KH:";
            // 
            // btnNVMo
            // 
            this.btnNVMo.BackColor = System.Drawing.Color.DarkGray;
            this.btnNVMo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVMo.Location = new System.Drawing.Point(43, 199);
            this.btnNVMo.Name = "btnNVMo";
            this.btnNVMo.Size = new System.Drawing.Size(90, 28);
            this.btnNVMo.TabIndex = 23;
            this.btnNVMo.Text = "Mở";
            this.btnNVMo.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "tìm theo tên";
            // 
            // txbNVTim
            // 
            this.txbNVTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNVTim.Location = new System.Drawing.Point(568, 238);
            this.txbNVTim.Name = "txbNVTim";
            this.txbNVTim.Size = new System.Drawing.Size(126, 26);
            this.txbNVTim.TabIndex = 21;
            this.txbNVTim.TextChanged += new System.EventHandler(this.txbNVTim_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(431, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = " Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 147);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "SDT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Họ tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Danh sách nhân viên:";
            // 
            // btnNVThoat
            // 
            this.btnNVThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnNVThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVThoat.Location = new System.Drawing.Point(729, 236);
            this.btnNVThoat.Name = "btnNVThoat";
            this.btnNVThoat.Size = new System.Drawing.Size(90, 28);
            this.btnNVThoat.TabIndex = 16;
            this.btnNVThoat.Text = "Thoát";
            this.btnNVThoat.UseVisualStyleBackColor = false;
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnNVXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVXoa.Location = new System.Drawing.Point(235, 234);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(90, 28);
            this.btnNVXoa.TabIndex = 14;
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.UseVisualStyleBackColor = false;
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVSua
            // 
            this.btnNVSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnNVSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVSua.Location = new System.Drawing.Point(139, 234);
            this.btnNVSua.Name = "btnNVSua";
            this.btnNVSua.Size = new System.Drawing.Size(90, 28);
            this.btnNVSua.TabIndex = 13;
            this.btnNVSua.Text = "Sửa";
            this.btnNVSua.UseVisualStyleBackColor = false;
            // 
            // btnNVThem
            // 
            this.btnNVThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnNVThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVThem.Location = new System.Drawing.Point(43, 234);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(90, 28);
            this.btnNVThem.TabIndex = 12;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = false;
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // txbNVDiaChi
            // 
            this.txbNVDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNVDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNVDiaChi.Location = new System.Drawing.Point(521, 70);
            this.txbNVDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbNVDiaChi.Multiline = true;
            this.txbNVDiaChi.Name = "txbNVDiaChi";
            this.txbNVDiaChi.Size = new System.Drawing.Size(145, 29);
            this.txbNVDiaChi.TabIndex = 11;
            // 
            // txbNVSDT
            // 
            this.txbNVSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNVSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNVSDT.Location = new System.Drawing.Point(152, 142);
            this.txbNVSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txbNVSDT.Multiline = true;
            this.txbNVSDT.Name = "txbNVSDT";
            this.txbNVSDT.Size = new System.Drawing.Size(145, 29);
            this.txbNVSDT.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpNhanVien);
            this.tabControl1.Controls.Add(this.tpKhachHang);
            this.tabControl1.Controls.Add(this.tpHoaDon);
            this.tabControl1.Controls.Add(this.tpChiTietHoaDon);
            this.tabControl1.Controls.Add(this.tpMang);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(859, 608);
            this.tabControl1.TabIndex = 8;
            // 
            // tpNhanVien
            // 
            this.tpNhanVien.BackColor = System.Drawing.Color.Snow;
            this.tpNhanVien.Controls.Add(this.btnNVMo);
            this.tpNhanVien.Controls.Add(this.label11);
            this.tpNhanVien.Controls.Add(this.txbNVTim);
            this.tpNhanVien.Controls.Add(this.label10);
            this.tpNhanVien.Controls.Add(this.label9);
            this.tpNhanVien.Controls.Add(this.label8);
            this.tpNhanVien.Controls.Add(this.label7);
            this.tpNhanVien.Controls.Add(this.btnNVThoat);
            this.tpNhanVien.Controls.Add(this.btnNVXoa);
            this.tpNhanVien.Controls.Add(this.btnNVSua);
            this.tpNhanVien.Controls.Add(this.btnNVThem);
            this.tpNhanVien.Controls.Add(this.txbNVDiaChi);
            this.tpNhanVien.Controls.Add(this.txbNVSDT);
            this.tpNhanVien.Controls.Add(this.txbNVHoTen);
            this.tpNhanVien.Controls.Add(this.dtThongTinNhanVien);
            this.tpNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tpNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.tpNhanVien.Name = "tpNhanVien";
            this.tpNhanVien.Padding = new System.Windows.Forms.Padding(2);
            this.tpNhanVien.Size = new System.Drawing.Size(851, 582);
            this.tpNhanVien.TabIndex = 0;
            this.tpNhanVien.Text = "Nhân Viên";
            this.tpNhanVien.Click += new System.EventHandler(this.tpNhanVien_Click);
            // 
            // txbNVHoTen
            // 
            this.txbNVHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNVHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNVHoTen.Location = new System.Drawing.Point(152, 65);
            this.txbNVHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txbNVHoTen.Multiline = true;
            this.txbNVHoTen.Name = "txbNVHoTen";
            this.txbNVHoTen.Size = new System.Drawing.Size(145, 29);
            this.txbNVHoTen.TabIndex = 9;
            // 
            // dtThongTinNhanVien
            // 
            this.dtThongTinNhanVien.AllowUserToAddRows = false;
            this.dtThongTinNhanVien.AllowUserToDeleteRows = false;
            this.dtThongTinNhanVien.AllowUserToResizeColumns = false;
            this.dtThongTinNhanVien.AllowUserToResizeRows = false;
            this.dtThongTinNhanVien.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtThongTinNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongTinNhanVien.Location = new System.Drawing.Point(0, 323);
            this.dtThongTinNhanVien.Name = "dtThongTinNhanVien";
            this.dtThongTinNhanVien.ReadOnly = true;
            this.dtThongTinNhanVien.RowHeadersVisible = false;
            this.dtThongTinNhanVien.RowHeadersWidth = 51;
            this.dtThongTinNhanVien.Size = new System.Drawing.Size(851, 259);
            this.dtThongTinNhanVien.TabIndex = 2;
            this.dtThongTinNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtThongTinNhanVien_CellContentClick);
            // 
            // tpKhachHang
            // 
            this.tpKhachHang.Controls.Add(this.btnKHSuaLuu);
            this.tpKhachHang.Controls.Add(this.dtThongTinKhachHang);
            this.tpKhachHang.Controls.Add(this.label6);
            this.tpKhachHang.Controls.Add(this.label5);
            this.tpKhachHang.Controls.Add(this.label4);
            this.tpKhachHang.Controls.Add(this.label3);
            this.tpKhachHang.Controls.Add(this.label2);
            this.tpKhachHang.Controls.Add(this.txbKHEmail);
            this.tpKhachHang.Controls.Add(this.txbKHDiaChi);
            this.tpKhachHang.Controls.Add(this.txbKHSDT);
            this.tpKhachHang.Controls.Add(this.txbKHHoTen);
            this.tpKhachHang.Controls.Add(this.btnKHThoat);
            this.tpKhachHang.Controls.Add(this.btnKHThem);
            this.tpKhachHang.Controls.Add(this.txbKHTim);
            this.tpKhachHang.Controls.Add(this.label1);
            this.tpKhachHang.Controls.Add(this.btnKHXoa);
            this.tpKhachHang.Controls.Add(this.btnKHSua);
            this.tpKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpKhachHang.Location = new System.Drawing.Point(4, 22);
            this.tpKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.tpKhachHang.Name = "tpKhachHang";
            this.tpKhachHang.Padding = new System.Windows.Forms.Padding(2);
            this.tpKhachHang.Size = new System.Drawing.Size(851, 582);
            this.tpKhachHang.TabIndex = 1;
            this.tpKhachHang.Text = "Khách Hàng";
            this.tpKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnKHSuaLuu
            // 
            this.btnKHSuaLuu.BackColor = System.Drawing.Color.DarkGray;
            this.btnKHSuaLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHSuaLuu.Location = new System.Drawing.Point(362, 235);
            this.btnKHSuaLuu.Name = "btnKHSuaLuu";
            this.btnKHSuaLuu.Size = new System.Drawing.Size(89, 28);
            this.btnKHSuaLuu.TabIndex = 18;
            this.btnKHSuaLuu.Text = "Lưu";
            this.btnKHSuaLuu.UseVisualStyleBackColor = false;
            this.btnKHSuaLuu.Click += new System.EventHandler(this.btnKHSuaLuu_Click);
            // 
            // dtThongTinKhachHang
            // 
            this.dtThongTinKhachHang.AllowUserToAddRows = false;
            this.dtThongTinKhachHang.AllowUserToDeleteRows = false;
            this.dtThongTinKhachHang.AllowUserToResizeColumns = false;
            this.dtThongTinKhachHang.AllowUserToResizeRows = false;
            this.dtThongTinKhachHang.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtThongTinKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongTinKhachHang.Location = new System.Drawing.Point(0, 328);
            this.dtThongTinKhachHang.Name = "dtThongTinKhachHang";
            this.dtThongTinKhachHang.ReadOnly = true;
            this.dtThongTinKhachHang.RowHeadersVisible = false;
            this.dtThongTinKhachHang.RowHeadersWidth = 51;
            this.dtThongTinKhachHang.Size = new System.Drawing.Size(851, 254);
            this.dtThongTinKhachHang.TabIndex = 17;
            this.dtThongTinKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtThongTinKhachHang_CellClick);
            this.dtThongTinKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtThongTinKhachHang_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Danh sách khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "SDT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Họ tên:";
            // 
            // txbKHEmail
            // 
            this.txbKHEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKHEmail.Location = new System.Drawing.Point(580, 124);
            this.txbKHEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbKHEmail.Multiline = true;
            this.txbKHEmail.Name = "txbKHEmail";
            this.txbKHEmail.Size = new System.Drawing.Size(145, 29);
            this.txbKHEmail.TabIndex = 11;
            // 
            // txbKHDiaChi
            // 
            this.txbKHDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKHDiaChi.Location = new System.Drawing.Point(580, 60);
            this.txbKHDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txbKHDiaChi.Multiline = true;
            this.txbKHDiaChi.Name = "txbKHDiaChi";
            this.txbKHDiaChi.Size = new System.Drawing.Size(145, 29);
            this.txbKHDiaChi.TabIndex = 10;
            // 
            // txbKHSDT
            // 
            this.txbKHSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKHSDT.Location = new System.Drawing.Point(175, 124);
            this.txbKHSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txbKHSDT.Multiline = true;
            this.txbKHSDT.Name = "txbKHSDT";
            this.txbKHSDT.Size = new System.Drawing.Size(145, 29);
            this.txbKHSDT.TabIndex = 9;
            // 
            // txbKHHoTen
            // 
            this.txbKHHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKHHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txbKHHoTen.Location = new System.Drawing.Point(175, 60);
            this.txbKHHoTen.Margin = new System.Windows.Forms.Padding(2);
            this.txbKHHoTen.Multiline = true;
            this.txbKHHoTen.Name = "txbKHHoTen";
            this.txbKHHoTen.Size = new System.Drawing.Size(145, 29);
            this.txbKHHoTen.TabIndex = 8;
            // 
            // btnKHThoat
            // 
            this.btnKHThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnKHThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHThoat.Location = new System.Drawing.Point(748, 232);
            this.btnKHThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKHThoat.Name = "btnKHThoat";
            this.btnKHThoat.Size = new System.Drawing.Size(90, 29);
            this.btnKHThoat.TabIndex = 7;
            this.btnKHThoat.Text = "Thoát";
            this.btnKHThoat.UseVisualStyleBackColor = false;
            this.btnKHThoat.Click += new System.EventHandler(this.btnKHThoat_Click);
            // 
            // btnKHThem
            // 
            this.btnKHThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnKHThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHThem.Location = new System.Drawing.Point(38, 232);
            this.btnKHThem.Name = "btnKHThem";
            this.btnKHThem.Size = new System.Drawing.Size(90, 28);
            this.btnKHThem.TabIndex = 2;
            this.btnKHThem.Text = "Thêm";
            this.btnKHThem.UseVisualStyleBackColor = false;
            this.btnKHThem.Click += new System.EventHandler(this.btnKHThem_Click);
            // 
            // txbKHTim
            // 
            this.txbKHTim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKHTim.Location = new System.Drawing.Point(586, 229);
            this.txbKHTim.Multiline = true;
            this.txbKHTim.Name = "txbKHTim";
            this.txbKHTim.Size = new System.Drawing.Size(126, 30);
            this.txbKHTim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "tìm theo tên";
            // 
            // btnKHXoa
            // 
            this.btnKHXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnKHXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHXoa.Location = new System.Drawing.Point(230, 231);
            this.btnKHXoa.Name = "btnKHXoa";
            this.btnKHXoa.Size = new System.Drawing.Size(89, 28);
            this.btnKHXoa.TabIndex = 6;
            this.btnKHXoa.Text = "Xóa";
            this.btnKHXoa.UseVisualStyleBackColor = false;
            this.btnKHXoa.Click += new System.EventHandler(this.btnKHXoa_Click);
            // 
            // btnKHSua
            // 
            this.btnKHSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnKHSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKHSua.Location = new System.Drawing.Point(134, 230);
            this.btnKHSua.Name = "btnKHSua";
            this.btnKHSua.Size = new System.Drawing.Size(90, 30);
            this.btnKHSua.TabIndex = 3;
            this.btnKHSua.Text = "Sửa";
            this.btnKHSua.UseVisualStyleBackColor = false;
            // 
            // tpHoaDon
            // 
            this.tpHoaDon.Controls.Add(this.lblTimHD);
            this.tpHoaDon.Controls.Add(this.dtpNgayTimHD);
            this.tpHoaDon.Controls.Add(this.label24);
            this.tpHoaDon.Controls.Add(this.cboHDMaKH);
            this.tpHoaDon.Controls.Add(this.cboHDMaNV);
            this.tpHoaDon.Controls.Add(this.dgvThongTinHoaDon);
            this.tpHoaDon.Controls.Add(this.label17);
            this.tpHoaDon.Controls.Add(this.dtpNgayTaoHD);
            this.tpHoaDon.Controls.Add(this.label16);
            this.tpHoaDon.Controls.Add(this.label15);
            this.tpHoaDon.Controls.Add(this.btnHDThoat);
            this.tpHoaDon.Controls.Add(this.btnHDIn);
            this.tpHoaDon.Controls.Add(this.btnHDXoa);
            this.tpHoaDon.Controls.Add(this.btnHDSua);
            this.tpHoaDon.Controls.Add(this.btnHDThem);
            this.tpHoaDon.Controls.Add(this.label12);
            this.tpHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tpHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.tpHoaDon.Name = "tpHoaDon";
            this.tpHoaDon.Size = new System.Drawing.Size(851, 582);
            this.tpHoaDon.TabIndex = 2;
            this.tpHoaDon.Text = "Hóa Đơn";
            this.tpHoaDon.UseVisualStyleBackColor = true;
            // 
            // lblTimHD
            // 
            this.lblTimHD.AutoSize = true;
            this.lblTimHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimHD.Location = new System.Drawing.Point(499, 271);
            this.lblTimHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimHD.Name = "lblTimHD";
            this.lblTimHD.Size = new System.Drawing.Size(74, 16);
            this.lblTimHD.TabIndex = 38;
            this.lblTimHD.Text = "Tìm thấy :";
            // 
            // dtpNgayTimHD
            // 
            this.dtpNgayTimHD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTimHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTimHD.Location = new System.Drawing.Point(502, 243);
            this.dtpNgayTimHD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayTimHD.Name = "dtpNgayTimHD";
            this.dtpNgayTimHD.Size = new System.Drawing.Size(124, 26);
            this.dtpNgayTimHD.TabIndex = 36;
            this.dtpNgayTimHD.ValueChanged += new System.EventHandler(this.dtpNgayTim_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(377, 245);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 20);
            this.label24.TabIndex = 35;
            this.label24.Text = "Tìm theo ngày";
            // 
            // cboHDMaKH
            // 
            this.cboHDMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDMaKH.FormattingEnabled = true;
            this.cboHDMaKH.Location = new System.Drawing.Point(133, 78);
            this.cboHDMaKH.Name = "cboHDMaKH";
            this.cboHDMaKH.Size = new System.Drawing.Size(205, 28);
            this.cboHDMaKH.TabIndex = 34;
            // 
            // cboHDMaNV
            // 
            this.cboHDMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDMaNV.FormattingEnabled = true;
            this.cboHDMaNV.Location = new System.Drawing.Point(133, 159);
            this.cboHDMaNV.Name = "cboHDMaNV";
            this.cboHDMaNV.Size = new System.Drawing.Size(205, 28);
            this.cboHDMaNV.TabIndex = 33;
            // 
            // dgvThongTinHoaDon
            // 
            this.dgvThongTinHoaDon.AllowUserToAddRows = false;
            this.dgvThongTinHoaDon.AllowUserToDeleteRows = false;
            this.dgvThongTinHoaDon.AllowUserToResizeColumns = false;
            this.dgvThongTinHoaDon.AllowUserToResizeRows = false;
            this.dgvThongTinHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHoaDon.Location = new System.Drawing.Point(0, 329);
            this.dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            this.dgvThongTinHoaDon.ReadOnly = true;
            this.dgvThongTinHoaDon.RowHeadersVisible = false;
            this.dgvThongTinHoaDon.RowHeadersWidth = 51;
            this.dgvThongTinHoaDon.Size = new System.Drawing.Size(851, 253);
            this.dgvThongTinHoaDon.TabIndex = 32;
            this.dgvThongTinHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtThongTinHoaDon_CellClick);
            this.dgvThongTinHoaDon.CurrentCellChanged += new System.EventHandler(this.dtThongTinHoaDon_CurrentCellChanged);
            // 
            // btnHDThoat
            // 
            this.btnHDThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnHDThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDThoat.Location = new System.Drawing.Point(712, 241);
            this.btnHDThoat.Name = "btnHDThoat";
            this.btnHDThoat.Size = new System.Drawing.Size(90, 28);
            this.btnHDThoat.TabIndex = 26;
            this.btnHDThoat.Text = "Thoát";
            this.btnHDThoat.UseVisualStyleBackColor = false;
            // 
            // btnHDIn
            // 
            this.btnHDIn.BackColor = System.Drawing.Color.DarkGray;
            this.btnHDIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDIn.Location = new System.Drawing.Point(365, 159);
            this.btnHDIn.Name = "btnHDIn";
            this.btnHDIn.Size = new System.Drawing.Size(90, 28);
            this.btnHDIn.TabIndex = 25;
            this.btnHDIn.Text = "In";
            this.btnHDIn.UseVisualStyleBackColor = false;
            this.btnHDIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHDXoa
            // 
            this.btnHDXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnHDXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDXoa.Location = new System.Drawing.Point(248, 241);
            this.btnHDXoa.Name = "btnHDXoa";
            this.btnHDXoa.Size = new System.Drawing.Size(90, 28);
            this.btnHDXoa.TabIndex = 24;
            this.btnHDXoa.Text = "Xóa";
            this.btnHDXoa.UseVisualStyleBackColor = false;
            this.btnHDXoa.Click += new System.EventHandler(this.btnHDXoa_Click);
            // 
            // btnHDSua
            // 
            this.btnHDSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnHDSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDSua.Location = new System.Drawing.Point(152, 241);
            this.btnHDSua.Name = "btnHDSua";
            this.btnHDSua.Size = new System.Drawing.Size(90, 28);
            this.btnHDSua.TabIndex = 23;
            this.btnHDSua.Text = "Sửa";
            this.btnHDSua.UseVisualStyleBackColor = false;
            this.btnHDSua.Click += new System.EventHandler(this.btnHDSua_Click);
            // 
            // btnHDThem
            // 
            this.btnHDThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnHDThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHDThem.Location = new System.Drawing.Point(56, 241);
            this.btnHDThem.Name = "btnHDThem";
            this.btnHDThem.Size = new System.Drawing.Size(90, 28);
            this.btnHDThem.TabIndex = 22;
            this.btnHDThem.Text = "Thêm";
            this.btnHDThem.UseVisualStyleBackColor = false;
            this.btnHDThem.Click += new System.EventHandler(this.btnHDThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 300);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Danh sách hóa đơn:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Quản lý thu tiền mạng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tpChiTietHoaDon.ResumeLayout(false);
            this.tpChiTietHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinCTHoaDon)).EndInit();
            this.tpMang.ResumeLayout(false);
            this.tpMang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinMang)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpNhanVien.ResumeLayout(false);
            this.tpNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinNhanVien)).EndInit();
            this.tpKhachHang.ResumeLayout(false);
            this.tpKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinKhachHang)).EndInit();
            this.tpHoaDon.ResumeLayout(false);
            this.tpHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txbCTHDTim;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbMTenMang;
        private System.Windows.Forms.DateTimePicker dtpNgayTaoHD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCTHDThoat;
        private System.Windows.Forms.Button btnCTHDXoa;
        private System.Windows.Forms.Button btnCTHDSua;
        private System.Windows.Forms.Button btnCTHDThem;
        private System.Windows.Forms.TextBox txtCTHDSoThangDK;
        private System.Windows.Forms.TabPage tpChiTietHoaDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txbMtim;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnMThoat;
        private System.Windows.Forms.Button btnMTim;
        private System.Windows.Forms.Button btnMXoa;
        private System.Windows.Forms.Button btnMSua;
        private System.Windows.Forms.Button btnMThem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbMMota;
        private System.Windows.Forms.TextBox txbMDonGia;
        private System.Windows.Forms.TabPage tpMang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnNVMo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbNVTim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNVThoat;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVSua;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.TextBox txbNVDiaChi;
        private System.Windows.Forms.TextBox txbNVSDT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpNhanVien;
        private System.Windows.Forms.TextBox txbNVHoTen;
        private System.Windows.Forms.DataGridView dtThongTinNhanVien;
        private System.Windows.Forms.TabPage tpKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbKHEmail;
        private System.Windows.Forms.TextBox txbKHDiaChi;
        private System.Windows.Forms.TextBox txbKHSDT;
        private System.Windows.Forms.TextBox txbKHHoTen;
        private System.Windows.Forms.Button btnKHThoat;
        private System.Windows.Forms.Button btnKHThem;
        private System.Windows.Forms.TextBox txbKHTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKHXoa;
        private System.Windows.Forms.Button btnKHSua;
        private System.Windows.Forms.TabPage tpHoaDon;
        private System.Windows.Forms.Button btnHDThoat;
        private System.Windows.Forms.Button btnHDXoa;
        private System.Windows.Forms.Button btnHDSua;
        private System.Windows.Forms.Button btnHDThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dtThongTinKhachHang;
        private System.Windows.Forms.DataGridView dgvThongTinHoaDon;
        private ComboBox cboHDMaNV;
        private ComboBox cboHDMaKH;
        private DataGridView dgvThongTinCTHoaDon;
        private DataGridView dtThongTinMang;
        private ComboBox cboCTHDMaMang;
        private ComboBox cboCTHDMaHD;
        private Button btnKHSuaLuu;
        private Button btnHDIn;
        private DateTimePicker dtpNgayTimHD;
        private Label label24;
        private Label lblTimHD;
        private Label label26;
        private Label lblTimCTHD;
    }
}
