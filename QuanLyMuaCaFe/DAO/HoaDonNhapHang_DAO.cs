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
    public class HoaDonNhapHang_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<HoaDonNhapHang_DTO> GetListHDNH()
        {
            List<HoaDonNhapHang_DTO> Danhsach = new List<HoaDonNhapHang_DTO>();
            try
            {
                HoaDonNhapHang_DTO HD;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_GetListHDNhapHang", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HD = new HoaDonNhapHang_DTO();
                    HD.MaHoaDonNhap = reader["MaHD_Nhap"].ToString();
                    HD.MaNhaCungCap = reader["MaNCC"].ToString();
                    HD.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
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
        public static List<HoaDonNhapHang_DTO> Search_HDBH(HoaDonNhapHang_DTO HoaDonNhapHang_DTO)
        {
            List<HoaDonNhapHang_DTO> Danhsach = new List<HoaDonNhapHang_DTO>();
            HoaDonNhapHang_DTO HD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchHDNhapHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchHDNH", "%" + HoaDonNhapHang_DTO.MaHoaDonNhap + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    HD = new HoaDonNhapHang_DTO();
                    HD.MaHoaDonNhap = reader["MaHD_Nhap"].ToString();
                    HD.MaNhaCungCap = reader["MaNCC"].ToString();
                    HD.NgayNhap = DateTime.Parse(reader["NgayNhap"].ToString());
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
        public static List<HoaDonNhapHang_DTO> TinhTongTien()
        {
            List<HoaDonNhapHang_DTO> Danhsach = new List<HoaDonNhapHang_DTO>();
            HoaDonNhapHang_DTO CTHD;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_TongHDNhapHang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CTHD = new HoaDonNhapHang_DTO();
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
