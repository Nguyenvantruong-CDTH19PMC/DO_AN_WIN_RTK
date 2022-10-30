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
    public partial class Bao_cao : Form
    {
        public Bao_cao()
        {
            InitializeComponent();
        }

        private void Bao_cao_Load(object sender, EventArgs e)
        {
            
        }

        private void Bao_cao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
