using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Do_an_quan_ly_khach_san
{
    public partial class Dang_ky : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-QISVQOP\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from PHONG,DANGKY where DANGKY.MaPhong = PHONG.MaPhong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvChonPhong.DataSource = table;
        }

        public Dang_ky()
        {
            InitializeComponent();
        }

        private void btnQL_Click(object sender, EventArgs e)
        {
            Trang_chu f = new Trang_chu();
            this.Hide();
            f.ShowDialog();
        }

        private void Dang_ky_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void Dang_ky_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void dgvChonPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvChonPhong.CurrentRow.Index;
           // txtSoDK.Text = dgvChonPhong.Rows[i].Cells[0].Value.ToString();
        }
    }
}
