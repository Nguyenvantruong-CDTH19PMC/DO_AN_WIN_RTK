namespace Do_an_quan_ly_khach_san
{
    partial class Dang_nhap
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
            this.ptb_IconMatKhau = new System.Windows.Forms.PictureBox();
            this.ptb_IconTaiKhoan = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkHienThiMK = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_IconMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_IconTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_IconMatKhau
            // 
            this.ptb_IconMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_IconMatKhau.Location = new System.Drawing.Point(189, 169);
            this.ptb_IconMatKhau.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ptb_IconMatKhau.Name = "ptb_IconMatKhau";
            this.ptb_IconMatKhau.Size = new System.Drawing.Size(60, 46);
            this.ptb_IconMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_IconMatKhau.TabIndex = 12;
            this.ptb_IconMatKhau.TabStop = false;
            // 
            // ptb_IconTaiKhoan
            // 
            this.ptb_IconTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_IconTaiKhoan.Location = new System.Drawing.Point(189, 93);
            this.ptb_IconTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ptb_IconTaiKhoan.Name = "ptb_IconTaiKhoan";
            this.ptb_IconTaiKhoan.Size = new System.Drawing.Size(60, 46);
            this.ptb_IconTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_IconTaiKhoan.TabIndex = 13;
            this.ptb_IconTaiKhoan.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(256, 293);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 56);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(414, 284);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(227, 65);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkHienThiMK
            // 
            this.chkHienThiMK.AutoSize = true;
            this.chkHienThiMK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkHienThiMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThiMK.ForeColor = System.Drawing.Color.White;
            this.chkHienThiMK.Location = new System.Drawing.Point(365, 229);
            this.chkHienThiMK.Margin = new System.Windows.Forms.Padding(4);
            this.chkHienThiMK.Name = "chkHienThiMK";
            this.chkHienThiMK.Size = new System.Drawing.Size(245, 33);
            this.chkHienThiMK.TabIndex = 9;
            this.chkHienThiMK.Text = "Hiển thị mật khẩu";
            this.chkHienThiMK.UseVisualStyleBackColor = false;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(256, 169);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = true;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '★';
            this.txtMatKhau.Size = new System.Drawing.Size(385, 48);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(256, 93);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.Multiline = true;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(385, 48);
            this.txtTenDangNhap.TabIndex = 7;
            this.txtTenDangNhap.Text = "Tên Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 67);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đăng Nhập";
            // 
            // Dang_nhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptb_IconMatKhau);
            this.Controls.Add(this.ptb_IconTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkHienThiMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Name = "Dang_nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dang_nhap_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_IconMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_IconTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_IconMatKhau;
        private System.Windows.Forms.PictureBox ptb_IconTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkHienThiMK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label1;
    }
}

