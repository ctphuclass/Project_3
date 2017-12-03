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
    public class NhanVien_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public List<NhanVien_DTO> GetListNV()
        {
            List<NhanVien_DTO> Danhsach = new List<NhanVien_DTO>();
            NhanVien_DTO NV;
            try
            {
                SqlCommand cmd = new SqlCommand("proc_GetListNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NV = new NhanVien_DTO();
                    NV.MaNV = reader["Ma_NV"].ToString();
                    NV.HoTenNV = reader["HoTen_NV"].ToString();
                    NV.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    NV.GioiTinh = reader["GioiTinh"].ToString();
                    NV.QueQuan = reader["QueQuan"].ToString();
                    NV.DiaChi = reader["DiaChi"].ToString();
                    NV.Email = reader["Email"].ToString();
                    NV.SDT = reader["SoDienThoai"].ToString();
                    Danhsach.Add(NV);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Danhsach = null;
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
        public static bool New_NV(NhanVien_DTO NewNV)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_InsertNewNV @Ma_NV = '{0}', @HoTen_NV = N'{1}',@NgaySinh='{2}',@GioiTinh = N'{3}',@QueQuan = N'{4}',@DiaChi=N'{5}',@Email = '{6}', @SoDienThoai='{7}'",);
                SqlCommand cmd = new SqlCommand(New, con);
                int i = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}
