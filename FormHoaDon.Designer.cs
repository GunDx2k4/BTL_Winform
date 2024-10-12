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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttHDNgayTao = new System.Windows.Forms.DateTimePicker();
            this.grThongTinHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThongTinHoaDon
            // 
            this.grThongTinHoaDon.Controls.Add(this.ttHDNgayTao);
            this.grThongTinHoaDon.Controls.Add(this.label2);
            this.grThongTinHoaDon.Controls.Add(this.textBox2);
            this.grThongTinHoaDon.Controls.Add(this.label1);
            this.grThongTinHoaDon.Controls.Add(this.textBox1);
            this.grThongTinHoaDon.Controls.Add(this.label15);
            this.grThongTinHoaDon.Location = new System.Drawing.Point(14, 14);
            this.grThongTinHoaDon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grThongTinHoaDon.Name = "grThongTinHoaDon";
            this.grThongTinHoaDon.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grThongTinHoaDon.Size = new System.Drawing.Size(369, 227);
            this.grThongTinHoaDon.TabIndex = 0;
            this.grThongTinHoaDon.TabStop = false;
            this.grThongTinHoaDon.Text = "Thông tin hoa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(393, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(475, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(125, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 26);
            this.textBox1.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(125, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 26);
            this.textBox2.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Khách hàng";
            // 
            // ttHDNgayTao
            // 
            this.ttHDNgayTao.CustomFormat = "dd/MM/yyyy";
            this.ttHDNgayTao.Enabled = false;
            this.ttHDNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ttHDNgayTao.Location = new System.Drawing.Point(125, 108);
            this.ttHDNgayTao.Margin = new System.Windows.Forms.Padding(2);
            this.ttHDNgayTao.Name = "ttHDNgayTao";
            this.ttHDNgayTao.Size = new System.Drawing.Size(124, 26);
            this.ttHDNgayTao.TabIndex = 40;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grThongTinHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormHoaDon";
            this.Text = "FormCTHoaDon";
            this.grThongTinHoaDon.ResumeLayout(false);
            this.grThongTinHoaDon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker ttHDNgayTao;
    }
}