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
    public partial class DangNhap : Form      
    {
        nguoiDungDAL nd = new nguoiDungDAL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = nd.dangNhap(txtid.Text, txtpassword.Text);
            if (kq == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
            else
            {
                // thuoc f = new thuoc();

                //nd.quyen = 
                Form1 f = new Form1(this);
                f.Show();
                this.Hide();
                

            }
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            if (txtid.Text == "Tên đăng nhập")
                txtid.Text = "";
        }

        private void txtid_Leave(object sender, EventArgs e)
        {
            if (txtid.Text == "")
                txtid.Text = "Tên đăng nhập";

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Mật khẩu";
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Mật khẩu")
            {
                txtpassword.Text = "";
                txtpassword.UseSystemPasswordChar = false;
            }
        }
    }
}
