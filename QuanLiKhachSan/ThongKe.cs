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
using Microsoft.Reporting.WinForms;
namespace QuanLiKhachSan
{
    public partial class ThongKe : Form
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = QLKS; Integrated Security = True");
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            DataSet1 hd = new DataSet1();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from hoaDon  ", con);
            da.Fill(hd, hd.Tables[0].TableName);
            hoaDonBindingSource.DataSource = hd;
          //  ReportParameterCollection reportParameters = new ReportParameterCollection();

         //   reportParameters.Add(new ReportParameter("thang", "2"));

          //  this.reportViewer1.LocalReport.SetParameters(reportParameters);
            con.Close();
            this.reportViewer1.RefreshReport();
            
        }

        
    }
}
