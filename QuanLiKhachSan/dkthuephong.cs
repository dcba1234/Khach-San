using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QuanLiKhachSan
{
    public partial class dkthuephong : Form
    {
        Form1 f;
        PhongDAL p = new PhongDAL();
        public string madki;
        public string sdt, diachi,maHD,tenkh,makh,tienphong,tiendv;
        public dkthuephong(Form1 f)
        {
            InitializeComponent();
            this.f = f;

            datengayden.Format = DateTimePickerFormat.Custom;
            datengayden.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            datengaytao.Value = DateTime.Now;
            button3.Visible = false;
        }
        public dkthuephong(Form1 f,int i)
        {
            InitializeComponent();
            this.f = f;
            button2.Visible = false;
            txtghichu.Enabled = false;
            datengayden.Enabled = false;
            datengaydi.Enabled = false;
            button1.Visible = false;
            timengayden.Enabled = false;
            timengaydi.Enabled = false;
            SqlDataReader r = p.selectDKthue(f.sophong);
           
            while (r.HasRows)
            {
               

                while (r.Read())
                {
                    txtmkh.Text = r.GetInt32(0).ToString();
                    txttenkh.Text = r.GetString(1);
                    datengaytao.Value = r.GetDateTime(2);                   
                    datengayden.Value = r.GetDateTime(3);
                    timengayden.Value = r.GetDateTime(3);
                    datengaydi.Value = r.GetDateTime(4);
                    timengaydi.Value = r.GetDateTime(4);
                    txtghichu.Text = r.GetString(5);
                    madki = r.GetInt32(6).ToString();
                    lbmnv.Text = r.GetString(7);
                    sdt = r.GetString(8);
                    diachi = r.GetString(9);
                    break;
                }
                r.NextResult();
            }
            r.Close();
            

        }
        private void dkthuephong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //thêm
            // MessageBox.Show(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            p.insertDkthue(txtmkh.Text, f.sophong, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), datengayden.Value.ToString("MM/dd/yyyy")  +" "+ timengayden.Value.ToString("HH:mm:ss"), datengaydi.Value.ToString("MM/dd/yyyy") + " " + timengaydi.Value.ToString("HH:mm:ss"), txtghichu.Text, "1");
            p.updatePhong(f.sophong,"1");
            f.reload();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void loadKH(string makh,string tenkh,string sdt,string diachi)
        {
            txtmkh.Text = makh;
            txttenkh.Text = tenkh;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chonKH f = new chonKH(this);
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //trả
            //MessageBox.Show(sdt);
            
            maHD = p.selectMaHD().ToString();
            makh = txtmkh.Text;
            tenkh = txttenkh.Text;
            tiendv = "10000";
           
            
            TimeSpan difference =    DateTime.Now - datengayden.Value;
            double tongtienphong = double.Parse(f.gia) * Math.Round(difference.TotalDays,2);
            tienphong = tongtienphong.ToString();
           // MessageBox.Show(tongtienphong.ToString()  + "   /// "+ Math.Round(difference.TotalDays, 2));
            //MessageBox.Show( datengayden.Value+"  ///Ngày: " + difference.TotalDays);
            int soHoaDon = p.selectMaHD();
           
             p.updatePhong(f.sophong, "0");
            p.insertHD(maHD, madki, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), tienphong, "1", tiendv);
            //MessageBox.Show(soHoaDon.ToString());
            f.reload();
            hoaDon h = new hoaDon(this);
            h.ShowDialog();
            this.Close();
        }
    }
}
