using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DTO;

namespace DAO
{
    public class DoanhThu_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<DoanhThu_DTO> List_DoanhThu(DoanhThu_DTO DT)
        {
            List<DoanhThu_DTO> DoanhSach = new List<DoanhThu_DTO>();
            try
            {
                DoanhThu_DTO DoanhThu;
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_DoanhThu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayDau", DT.NgayDau);
                cmd.Parameters.AddWithValue("@NgayCuoi", DT.NgayCuoi);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoanhThu = new DoanhThu_DTO();
                    DoanhThu.MaHoaDon = reader["MaHoaDon"].ToString();
                    DoanhThu.MaBan = reader["MaBan"].ToString();
                    DoanhThu.TongTien = Int32.Parse(reader["TongTien"].ToString());
                    DoanhSach.Add(DoanhThu);
                }
                reader.Close();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return DoanhSach;
        }
        public static  List<DoanhThu_DTO> TongDoanhThu(DoanhThu_DTO DT)
        {
            List<DoanhThu_DTO> DoanhSach = new List<DoanhThu_DTO>();
            try
            {
                DoanhThu_DTO DoanhThu;
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_TongDoanhThu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NgayDau", DT.NgayDau);
                cmd.Parameters.AddWithValue("@NgayCuoi", DT.NgayCuoi);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DoanhThu = new DoanhThu_DTO();
                    DoanhThu.TongDoanhThu = Int32.Parse(reader["TongDoanhThu"].ToString());
                    DoanhSach.Add(DoanhThu);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                DT.Error = ex.ToString();
                
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return DoanhSach;
        }
    }
}
