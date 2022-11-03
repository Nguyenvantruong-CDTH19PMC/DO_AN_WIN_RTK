﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_an_quan_ly_khach_san
{
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Trang_chu f = new Trang_chu();
            
            if (txtTenDangNhap.Text=="admin"&&txtMatKhau.Text=="1234")
            {
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Dang_nhap dn = new Dang_nhap();
            dn.ShowDialog();

        }

        private void Dang_nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
