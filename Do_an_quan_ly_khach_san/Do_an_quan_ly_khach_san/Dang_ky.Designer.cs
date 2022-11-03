namespace Do_an_quan_ly_khach_san
{
    partial class Dang_ky
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
            this.btnTao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChonPhong = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.txtSoDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.btnTaoKH = new System.Windows.Forms.Button();
            this.cboLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayNhan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.btnQL = new System.Windows.Forms.Button();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.White;
            this.btnTao.Location = new System.Drawing.Point(280, 53);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(53, 27);
            this.btnTao.TabIndex = 20;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvChonPhong);
            this.groupBox2.Location = new System.Drawing.Point(509, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 347);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Phòng";
            // 
            // dgvChonPhong
            // 
            this.dgvChonPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChonPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChonPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhong,
            this.colGia,
            this.MaLoaiPhong,
            this.colTinhTrang});
            this.dgvChonPhong.Location = new System.Drawing.Point(6, 27);
            this.dgvChonPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvChonPhong.Name = "dgvChonPhong";
            this.dgvChonPhong.RowHeadersWidth = 62;
            this.dgvChonPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChonPhong.Size = new System.Drawing.Size(659, 307);
            this.dgvChonPhong.TabIndex = 10;
            this.dgvChonPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChonPhong_CellContentClick);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(126, 346);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(118, 51);
            this.btnDangKy.TabIndex = 18;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDK.Location = new System.Drawing.Point(489, 58);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(189, 22);
            this.dtpNgayDK.TabIndex = 17;
            // 
            // txtSoDK
            // 
            this.txtSoDK.Location = new System.Drawing.Point(157, 57);
            this.txtSoDK.Name = "txtSoDK";
            this.txtSoDK.Size = new System.Drawing.Size(119, 22);
            this.txtSoDK.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Số ĐK:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ngày ĐK:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboMaKH);
            this.groupBox1.Controls.Add(this.btnTaoKH);
            this.groupBox1.Controls.Add(this.cboLoaiDichVu);
            this.groupBox1.Controls.Add(this.dtpNgayTra);
            this.groupBox1.Controls.Add(this.dtpNgayNhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Location = new System.Drawing.Point(75, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 236);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng Ký Phòng";
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(141, 32);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(146, 24);
            this.cboMaKH.TabIndex = 13;
            // 
            // btnTaoKH
            // 
            this.btnTaoKH.BackColor = System.Drawing.Color.White;
            this.btnTaoKH.Location = new System.Drawing.Point(291, 29);
            this.btnTaoKH.Name = "btnTaoKH";
            this.btnTaoKH.Size = new System.Drawing.Size(99, 27);
            this.btnTaoKH.TabIndex = 12;
            this.btnTaoKH.Text = "Tạo KH";
            this.btnTaoKH.UseVisualStyleBackColor = false;
            // 
            // cboLoaiDichVu
            // 
            this.cboLoaiDichVu.FormattingEnabled = true;
            this.cboLoaiDichVu.Location = new System.Drawing.Point(141, 172);
            this.cboLoaiDichVu.Name = "cboLoaiDichVu";
            this.cboLoaiDichVu.Size = new System.Drawing.Size(146, 24);
            this.cboLoaiDichVu.TabIndex = 4;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(141, 137);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(258, 22);
            this.dtpNgayTra.TabIndex = 3;
            // 
            // dtpNgayNhan
            // 
            this.dtpNgayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhan.Location = new System.Drawing.Point(141, 102);
            this.dtpNgayNhan.Name = "dtpNgayNhan";
            this.dtpNgayNhan.Size = new System.Drawing.Size(258, 22);
            this.dtpNgayNhan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Dịch Vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày Nhận:";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(141, 64);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(146, 22);
            this.txtMaPhong.TabIndex = 0;
            // 
            // btnQL
            // 
            this.btnQL.Location = new System.Drawing.Point(300, 346);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(118, 51);
            this.btnQL.TabIndex = 21;
            this.btnQL.Text = "Quay lại";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Mã Phòng";
            this.colMaPhong.MinimumWidth = 8;
            this.colMaPhong.Name = "colMaPhong";
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "Gia";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.HeaderText = "Mã Loại Phòng";
            this.MaLoaiPhong.MinimumWidth = 6;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // colTinhTrang
            // 
            this.colTinhTrang.DataPropertyName = "TinhTrang";
            this.colTinhTrang.HeaderText = "Tình Trạng";
            this.colTinhTrang.MinimumWidth = 8;
            this.colTinhTrang.Name = "colTinhTrang";
            // 
            // Dang_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 504);
            this.Controls.Add(this.btnQL);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.txtSoDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dang_ky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dang_ky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dang_ky_FormClosing);
            this.Load += new System.EventHandler(this.Dang_ky_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChonPhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChonPhong;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.TextBox txtSoDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Button btnTaoKH;
        private System.Windows.Forms.ComboBox cboLoaiDichVu;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayNhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTinhTrang;
    }
}