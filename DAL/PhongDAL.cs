using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhongDAL:DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("phong_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insertKH(string tenKH, string cmnd, string sdt, string diachi)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_insert_khachHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenKH", tenKH));
            cmd.Parameters.Add(new SqlParameter("@cmnd", cmnd));
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
            cmd.Parameters.Add(new SqlParameter("@diachi", diachi));
            cmd.ExecuteNonQuery();
            closeC();
        }
        public void insertHD(string maHD,string maDKThue,string ngayTao,string tongTienPhong,string maNV,string tongTienDV)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_insert_hoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@maDKThue", maDKThue));
            cmd.Parameters.Add(new SqlParameter("@ngayTao", ngayTao));
            cmd.Parameters.Add(new SqlParameter("@tongTienPhong", tongTienPhong));
            cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmd.Parameters.Add(new SqlParameter("@tongTienDV", tongTienDV));
            
            
            cmd.ExecuteNonQuery();
            closeC();
        }
        public void insertDkthue(string maKH,string soPhong,string ngaytao,string ngayden, string ngaydi, string ghichu, string maNV )
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_insert_thuePhong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maKH", maKH));
            cmd.Parameters.Add(new SqlParameter("@soPhong", soPhong));
            cmd.Parameters.Add(new SqlParameter("@ngaytao", ngaytao));
            cmd.Parameters.Add(new SqlParameter("@ngayden", ngayden));
            cmd.Parameters.Add(new SqlParameter("@ngaydi", ngaydi));
            cmd.Parameters.Add(new SqlParameter("@ghichu", ghichu));
            cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmd.ExecuteNonQuery();
            closeC();   
        }

        public void updatePhong(string soPhong,string trangthai)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_update_phong", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@soPhong", soPhong));
            cmd.Parameters.Add(new SqlParameter("@trangthai", trangthai));
            cmd.ExecuteNonQuery();
            closeC();   
        }
        public int selectMaDK()
        {
            openC();
            SqlCommand cmd = new SqlCommand("select max(madk) from thuePhong", con);
            int kq;
            if (cmd.ExecuteScalar() == null) kq = 0;
            else
             kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq + 1;
        }
        public int selectMaKH()
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_getMKH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            int kq;
            if (cmd.ExecuteScalar() == null) kq = 0;
            else
                kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq + 1;
        }
        public int selectMaHD()
        {
            openC();
            SqlCommand cmd2 = new SqlCommand("select count(maHD) from hoaDon", con);
            SqlCommand cmd = new SqlCommand("select max(maHD) from hoaDon", con);   
            
            int kq;
            int count = (int)cmd2.ExecuteScalar();
            if (count == 0) kq = 0;
            else
                kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq + 1;
        }
        public DataTable selectKH()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("select maKH as 'Mã khách hàng',tenKH as 'Tên khách hàng' ,cmnd as 'Số CMND',sdt as 'Số điện thoại', diachi as 'Địa chỉ' from khachHang", con);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;
        }
        public SqlDataReader selectDKthue(string soPhong)
        {   
            
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_dkthue", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@soPhong", soPhong));
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
           //closeC();
            return reader;
            
        }

    }
}
