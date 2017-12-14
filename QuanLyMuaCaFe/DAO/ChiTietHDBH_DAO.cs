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
    public class ChiTietHDBH_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<ChiTietHDBH_DTO> Show_HDBH(ChiTietHDBH_DTO ChiTietHDBH_DTO)
        {
            List<ChiTietHDBH_DTO> Danhsach = new List<ChiTietHDBH_DTO>();
            ChiTietHDBH_DTO CTHD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_CTHD2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD",ChiTietHDBH_DTO.MaHoaDon);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CTHD = new ChiTietHDBH_DTO();
                    CTHD.TenMon = reader["TenMon"].ToString();
                    CTHD.SoLuong =Int32.Parse(reader["SoLuong"].ToString());
                    CTHD.DonGia = Int32.Parse(reader["DonGia"].ToString());
                    CTHD.ThanhTien = Int32.Parse(reader["ThanhTien"].ToString());
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
        public static List<ChiTietHDBH_DTO> TinhTongTien(ChiTietHDBH_DTO ChiTietHDBH_DTO)
        {
            List<ChiTietHDBH_DTO> Danhsach = new List<ChiTietHDBH_DTO>();
            ChiTietHDBH_DTO CTHD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_CTHD3", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", ChiTietHDBH_DTO.MaHoaDon);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CTHD = new ChiTietHDBH_DTO();
                    CTHD.MaHoaDon = reader["MaHoaDon"].ToString();
                    CTHD.TongTien = Int32.Parse(reader["TongTien"].ToString());
                    //CTHD.DonGia = Int32.Parse(reader["DonGia"].ToString());
                    //CTHD.ThanhTien = Int32.Parse(reader["ThanhTien"].ToString());
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
