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
using Microsoft.Reporting.WinForms;

namespace QuanLiKhachSan
{
    public partial class hoaDon : Form
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = QLKS; Integrated Security = True");
        dkthuephong f;
        public hoaDon(dkthuephong f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void hoaDon_Load(object sender, EventArgs e)
        {
            DataSet1 hd = new DataSet1();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from hoaDon where mahd = '"+ f.maHD +"'", con);
            da.Fill(hd, hd.Tables[0].TableName);
            hoaDonBindingSource.DataSource = hd;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            
            reportParameters.Add(new ReportParameter("tenkh", f.tenkh));
            reportParameters.Add(new ReportParameter("makh", f.makh));
            reportParameters.Add(new ReportParameter("sdt", f.sdt));
            reportParameters.Add(new ReportParameter("diachi", f.diachi));
            reportParameters.Add(new ReportParameter("mahd", f.maHD));
            reportParameters.Add(new ReportParameter("tienphong", f.tienphong));
            reportParameters.Add(new ReportParameter("dichvu", f.tiendv));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            con.Close();
            this.reportViewer1.RefreshReport();
        }
    }
}
