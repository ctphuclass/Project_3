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
    public class HDBanHang_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<HDBanHang_DTO> GetListHDBH()
        {
            List<HDBanHang_DTO> Danhsach = new List<HDBanHang_DTO>();
            try
            {
                HDBanHang_DTO HD;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_CTHD", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HD = new HDBanHang_DTO();
                    HD.MaHoaDon = reader["MaHoaDon"].ToString();
                    HD.MaBan = reader["MaBan"].ToString();
                    HD.TenBan = reader["TenBan"].ToString();
                    HD.Ma_NV = reader["Ma_NV"].ToString();
                    HD.NgayLap = DateTime.Parse(reader["NgayLap"].ToString());
                    Danhsach.Add(HD);
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
            return Danhsach;
        }
        public static List<HDBanHang_DTO> Search_HDBH(HDBanHang_DTO HDBanHang_DTO)
        {
            List<HDBanHang_DTO> Danhsach = new List<HDBanHang_DTO>();
            HDBanHang_DTO HD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchHDBH", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchHDBH","%"+HDBanHang_DTO.MaHoaDon+"%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HD = new HDBanHang_DTO();
                    HD.MaHoaDon = reader["MaHoaDon"].ToString();
                    HD.MaBan = reader["MaBan"].ToString();
                    HD.TenBan = reader["TenBan"].ToString();
                    HD.Ma_NV = reader["Ma_NV"].ToString();
                    HD.NgayLap = DateTime.Parse(reader["NgayLap"].ToString());
                    Danhsach.Add(HD);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch
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
            return Danhsach;
        }
    }
}
