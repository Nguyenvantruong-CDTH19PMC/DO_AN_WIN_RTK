using System;
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
    public partial class Trang_chu : Form
    {
        public Trang_chu()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chắc chắn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql_Phong p = new Ql_Phong();
            this.Hide();
            p.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql_Nhan_vien nv = new Ql_Nhan_vien();
            this.Hide();
            nv.ShowDialog();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dich_vu dv = new Dich_vu();
            this.Hide();
            dv.ShowDialog();   
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql_Khach_hang kh = new Ql_Khach_hang();
            this.Hide();
            kh.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ql_Hoa_don hd = new Ql_Hoa_don();
            this.Hide();
            hd.ShowDialog();
        }

        private void quảnLýĐăngKýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ql_Dang_ky dk=new Ql_Dang_ky();
            dk.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_ky f = new Dang_ky();
            this.Hide();
            f.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bao_cao bc=new Bao_cao();
            this.Hide();
            bc.ShowDialog();
        }

        private void Trang_chu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
