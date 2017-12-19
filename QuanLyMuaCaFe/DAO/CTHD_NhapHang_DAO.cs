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
    public class CTHD_NhapHang_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<CTHD_NhapHang_DTO> Show_HDNH(CTHD_NhapHang_DTO CTHD_NhapHang_DTO)
        {
            List<CTHD_NhapHang_DTO> Danhsach = new List<CTHD_NhapHang_DTO>();
            CTHD_NhapHang_DTO CTHD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_ShowHDNhapHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHDNH", CTHD_NhapHang_DTO.MaHDNH);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CTHD = new CTHD_NhapHang_DTO();
                    CTHD.MaNL = reader["MaNL"].ToString();
                    CTHD.TenNL = reader["TenNL"].ToString();
                    CTHD.SoLuong = Int32.Parse(reader["SoLuong"].ToString());
                    CTHD.DonGia = Int32.Parse(reader["DonGia"].ToString());
                    CTHD.DVT = reader["DVT"].ToString();
                    CTHD.TongTien = Int32.Parse(reader["TongTien"].ToString());
                    Danhsach.Add(CTHD);
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
