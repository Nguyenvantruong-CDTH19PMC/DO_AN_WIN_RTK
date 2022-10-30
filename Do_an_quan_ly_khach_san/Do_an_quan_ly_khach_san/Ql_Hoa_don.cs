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
    public partial class Ql_Hoa_don : Form
    {
        public Ql_Hoa_don()
        {
            InitializeComponent();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            Trang_chu f = new Trang_chu();
            this.Hide();
            f.ShowDialog();
        }

        private void Ql_Hoa_don_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
