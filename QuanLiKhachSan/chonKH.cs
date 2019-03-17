using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QuanLiKhachSan
{
    public partial class chonKH : Form
    {
        PhongDAL p = new PhongDAL();
        dkthuephong t;
        public chonKH(dkthuephong t)
        {
            InitializeComponent();
            this.t = t;
        }

        private void chonKH_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.selectKH();
        }
        public void reload()
        {
            dataGridView1.DataSource = p.selectKH();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            t.loadKH(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            themKHcs f = new themKHcs(this);
            f.ShowDialog();
        }
    }
}
