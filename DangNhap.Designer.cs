namespace BTL
{
    partial class DangNhap
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
            this.btnDNDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxHienMK = new System.Windows.Forms.CheckBox();
            this.btnDNThoat = new System.Windows.Forms.Button();
            this.txbDNMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDNDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDNTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDNDangKy
            // 
            this.btnDNDangKy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDNDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNDangKy.Location = new System.Drawing.Point(411, 284);
            this.btnDNDangKy.Name = "btnDNDangKy";
            this.btnDNDangKy.Size = new System.Drawing.Size(90, 28);
            this.btnDNDangKy.TabIndex = 28;
            this.btnDNDangKy.Text = "Đăng Ký";
            this.btnDNDangKy.UseVisualStyleBackColor = false;
            this.btnDNDangKy.Click += new System.EventHandler(this.btnDNDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bạn chưa có tài khoản?";
            // 
            // checkBoxHienMK
            // 
            this.checkBoxHienMK.AutoSize = true;
            this.checkBoxHienMK.Location = new System.Drawing.Point(303, 183);
            this.checkBoxHienMK.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHienMK.Name = "checkBoxHienMK";
            this.checkBoxHienMK.Size = new System.Drawing.Size(95, 17);
            this.checkBoxHienMK.TabIndex = 26;
            this.checkBoxHienMK.Text = "Hiện mật khẩu";
            this.checkBoxHienMK.UseVisualStyleBackColor = true;
            this.checkBoxHienMK.CheckedChanged += new System.EventHandler(this.checkBoxHienMK_CheckedChanged);
            // 
            // btnDNThoat
            // 
            this.btnDNThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnDNThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNThoat.Location = new System.Drawing.Point(281, 215);
            this.btnDNThoat.Name = "btnDNThoat";
            this.btnDNThoat.Size = new System.Drawing.Size(102, 28);
            this.btnDNThoat.TabIndex = 25;
            this.btnDNThoat.Text = "Thoát";
            this.btnDNThoat.UseVisualStyleBackColor = false;
            this.btnDNThoat.Click += new System.EventHandler(this.btnDNThoat_Click);
            // 
            // txbDNMatKhau
            // 
            this.txbDNMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDNMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDNMatKhau.Location = new System.Drawing.Point(212, 131);
            this.txbDNMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txbDNMatKhau.Multiline = true;
            this.txbDNMatKhau.Name = "txbDNMatKhau";
            this.txbDNMatKhau.PasswordChar = '•';
            this.txbDNMatKhau.Size = new System.Drawing.Size(156, 31);
            this.txbDNMatKhau.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mật Khẩu:";
            // 
            // btnDNDangNhap
            // 
            this.btnDNDangNhap.BackColor = System.Drawing.Color.DarkGray;
            this.btnDNDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNDangNhap.Location = new System.Drawing.Point(124, 215);
            this.btnDNDangNhap.Name = "btnDNDangNhap";
            this.btnDNDangNhap.Size = new System.Drawing.Size(102, 28);
            this.btnDNDangNhap.TabIndex = 22;
            this.btnDNDangNhap.Text = "Đăng Nhập";
            this.btnDNDangNhap.UseVisualStyleBackColor = false;
            this.btnDNDangNhap.Click += new System.EventHandler(this.btnDNDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tài Khoản:";
            // 
            // txbDNTaiKhoan
            // 
            this.txbDNTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDNTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDNTaiKhoan.Location = new System.Drawing.Point(212, 55);
            this.txbDNTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.txbDNTaiKhoan.Multiline = true;
            this.txbDNTaiKhoan.Name = "txbDNTaiKhoan";
            this.txbDNTaiKhoan.Size = new System.Drawing.Size(156, 31);
            this.txbDNTaiKhoan.TabIndex = 20;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDNDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxHienMK);
            this.Controls.Add(this.btnDNThoat);
            this.Controls.Add(this.txbDNMatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDNDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDNTaiKhoan);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDNDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHienMK;
        private System.Windows.Forms.Button btnDNThoat;
        private System.Windows.Forms.TextBox txbDNMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDNDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDNTaiKhoan;
    }
}