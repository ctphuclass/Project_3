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
    public class ThanhVien_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<ThanhVien_DTO> GetListTV()
        {
            try
            {
                List<ThanhVien_DTO> Danhsach = new List<ThanhVien_DTO>();
                ThanhVien_DTO TV;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_LoadTV", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TV = new ThanhVien_DTO();
                    TV.MaTV = reader["MaTV"].ToString();
                    TV.HoTen = reader["HoTen"].ToString();
                    TV.Email = reader["Email"].ToString();
                    TV.GioiTinh = reader["GioiTinh"].ToString();
                    TV.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    TV.DiaChi = reader["DiaChi"].ToString();
                    TV.DienThoai = reader["Dienthoai"].ToString();
                    TV.NgayLamThe = DateTime.Parse(reader["NgayLamThe"].ToString());
                    TV.NgayHetHan = DateTime.Parse(reader["NgayHetHan"].ToString());
                    Danhsach.Add(TV);
                }
                reader.Close();
                cmd.Dispose();
                return Danhsach;
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

        }
        public static bool New_TV(ThanhVien_DTO ThanhVien_DTO)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_NewTV @MaTV='{0}',@HoTen=N'{1}',@Email=N'{2}',@GioiTinh=N'{3}',@NgaySinh='{4}',@DiaChi=N'{5}',@DienThoai='{6}',@NgayLamThe='{7}',@NgayHetHan='{8}'",ThanhVien_DTO.MaTV,ThanhVien_DTO.HoTen,ThanhVien_DTO.Email,ThanhVien_DTO.GioiTinh,ThanhVien_DTO.NgaySinh,ThanhVien_DTO.DiaChi,ThanhVien_DTO.DienThoai,ThanhVien_DTO.NgayLamThe,ThanhVien_DTO.NgayHetHan);
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
