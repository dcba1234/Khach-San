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
    public partial class themKHcs : Form
    {
        PhongDAL p = new PhongDAL();
        chonKH d;
        public themKHcs(chonKH d)
        {
            InitializeComponent();
            this.d = d;
        }

        private void themKHcs_Load(object sender, EventArgs e)
        {
            lbmkh.Text = p.selectMaKH().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.insertKH(txttenkh.Text, txtcmnd.Text, txtsdt.Text, txtdiachi.Text);
            d.reload();
            this.Close();
        }
    }
}
