namespace BTL
{
    partial class FormHoaDon
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
            this.grThongTinHoaDon = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpHDNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.grThongTinGoiMang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSoThangDK = new System.Windows.Forms.TextBox();
            this.cboMaMang = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dtThongTinCTHoaDon = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.grThongTinHoaDon.SuspendLayout();
            this.grThongTinGoiMang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinHoaDon
            // 
            this.grThongTinHoaDon.Controls.Add(this.btnLuu);
            this.grThongTinHoaDon.Controls.Add(this.dtpHDNgayTao);
            this.grThongTinHoaDon.Controls.Add(this.label2);
            this.grThongTinHoaDon.Controls.Add(this.txtNhanVien);
            this.grThongTinHoaDon.Controls.Add(this.label1);
            this.grThongTinHoaDon.Controls.Add(this.txtKhachHang);
            this.grThongTinHoaDon.Controls.Add(this.label15);
            this.grThongTinHoaDon.Location = new System.Drawing.Point(14, 14);
            this.grThongTinHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.grThongTinHoaDon.Name = "grThongTinHoaDon";
            this.grThongTinHoaDon.Padding = new System.Windows.Forms.Padding(5);
            this.grThongTinHoaDon.Size = new System.Drawing.Size(369, 147);
            this.grThongTinHoaDon.TabIndex = 0;
            this.grThongTinHoaDon.TabStop = false;
            this.grThongTinHoaDon.Text = "Thông tin hóa đơn";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkGray;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(271, 111);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 28);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpHDNgayTao
            // 
            this.dtpHDNgayTao.CustomFormat = "dd/MM/yyyy";
            this.dtpHDNgayTao.Enabled = false;
            this.dtpHDNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHDNgayTao.Location = new System.Drawing.Point(125, 108);
            this.dtpHDNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHDNgayTao.Name = "dtpHDNgayTao";
            this.dtpHDNgayTao.Size = new System.Drawing.Size(124, 26);
            this.dtpHDNgayTao.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ngày tạo ";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(125, 73);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(207, 26);
            this.txtNhanVien.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nhân viên";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Enabled = false;
            this.txtKhachHang.Location = new System.Drawing.Point(125, 41);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(207, 26);
            this.txtKhachHang.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 44);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Khách hàng";
            // 
            // grThongTinGoiMang
            // 
            this.grThongTinGoiMang.Controls.Add(this.btnSua);
            this.grThongTinGoiMang.Controls.Add(this.btnXoa);
            this.grThongTinGoiMang.Controls.Add(this.btnThem);
            this.grThongTinGoiMang.Controls.Add(this.label20);
            this.grThongTinGoiMang.Controls.Add(this.txtSoThangDK);
            this.grThongTinGoiMang.Controls.Add(this.cboMaMang);
            this.grThongTinGoiMang.Controls.Add(this.label19);
            this.grThongTinGoiMang.Location = new System.Drawing.Point(393, 14);
            this.grThongTinGoiMang.Margin = new System.Windows.Forms.Padding(5);
            this.grThongTinGoiMang.Name = "grThongTinGoiMang";
            this.grThongTinGoiMang.Padding = new System.Windows.Forms.Padding(5);
            this.grThongTinGoiMang.Size = new System.Drawing.Size(333, 147);
            this.grThongTinGoiMang.TabIndex = 1;
            this.grThongTinGoiMang.TabStop = false;
            this.grThongTinGoiMang.Text = "Gói mạng đăng ký";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DarkGray;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(235, 111);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 28);
            this.btnXoa.TabIndex = 43;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkGray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(43, 111);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 28);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 79);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 20);
            this.label20.TabIndex = 40;
            this.label20.Text = "Số tháng đăng ký:";
            // 
            // txtSoThangDK
            // 
            this.txtSoThangDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThangDK.Location = new System.Drawing.Point(173, 74);
            this.txtSoThangDK.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoThangDK.Multiline = true;
            this.txtSoThangDK.Name = "txtSoThangDK";
            this.txtSoThangDK.Size = new System.Drawing.Size(153, 29);
            this.txtSoThangDK.TabIndex = 39;
            this.txtSoThangDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThangDK_KeyPress);
            // 
            // cboMaMang
            // 
            this.cboMaMang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaMang.FormattingEnabled = true;
            this.cboMaMang.Location = new System.Drawing.Point(113, 41);
            this.cboMaMang.Name = "cboMaMang";
            this.cboMaMang.Size = new System.Drawing.Size(212, 28);
            this.cboMaMang.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(21, 44);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 20);
            this.label19.TabIndex = 37;
            this.label19.Text = "Mã Mạng:";
            // 
            // dtThongTinCTHoaDon
            // 
            this.dtThongTinCTHoaDon.AllowUserToAddRows = false;
            this.dtThongTinCTHoaDon.AllowUserToDeleteRows = false;
            this.dtThongTinCTHoaDon.AllowUserToResizeColumns = false;
            this.dtThongTinCTHoaDon.AllowUserToResizeRows = false;
            this.dtThongTinCTHoaDon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtThongTinCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtThongTinCTHoaDon.Location = new System.Drawing.Point(12, 169);
            this.dtThongTinCTHoaDon.Name = "dtThongTinCTHoaDon";
            this.dtThongTinCTHoaDon.ReadOnly = true;
            this.dtThongTinCTHoaDon.RowHeadersVisible = false;
            this.dtThongTinCTHoaDon.RowHeadersWidth = 51;
            this.dtThongTinCTHoaDon.Size = new System.Drawing.Size(716, 180);
            this.dtThongTinCTHoaDon.TabIndex = 35;
            this.dtThongTinCTHoaDon.CurrentCellChanged += new System.EventHandler(this.dtThongTinCTHoaDon_CurrentCellChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(502, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 20);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Tổng tiền :";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DarkGray;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(139, 111);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 28);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 381);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtThongTinCTHoaDon);
            this.Controls.Add(this.grThongTinGoiMang);
            this.Controls.Add(this.grThongTinHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormHoaDon";
            this.Text = "FormCTHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.grThongTinHoaDon.ResumeLayout(false);
            this.grThongTinHoaDon.PerformLayout();
            this.grThongTinGoiMang.ResumeLayout(false);
            this.grThongTinGoiMang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtThongTinCTHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinHoaDon;
        private System.Windows.Forms.GroupBox grThongTinGoiMang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpHDNgayTao;
        private System.Windows.Forms.ComboBox cboMaMang;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSoThangDK;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dtThongTinCTHoaDon;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
    }
}