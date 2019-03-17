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
    public partial class Form1 : Form
    {
        PhongDAL phong = new PhongDAL();
        public string sophong;
        public string gia;
        DangNhap f;
        public Form1(DangNhap f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initButton();
            dataGridView1.DataSource = phong.select();
        }

        private void initButton()
        {
            List<Button> buttons = new List<Button>();
            for (int i = 0; i < 10; i++)
            {
                Button newButton = new Button();
                buttons.Add(newButton);
                this.Controls.Add(newButton);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sophong = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dkthuephong f = new dkthuephong(this);
            f.ShowDialog();
            

        }
        public void reload()
        {
            dataGridView1.DataSource = phong.select();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if( dataGridView1.CurrentRow == null )
            {

            }
            else
            {
                if (!dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim().Equals("Không"))
                {
                    button4.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    button4.Enabled = true;
                    button1.Enabled = false;
                }
            }
            
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sophong = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            gia = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dkthuephong f = new dkthuephong(this,1);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThongKe k = new ThongKe();
            k.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.Close();
        }
    }
}
