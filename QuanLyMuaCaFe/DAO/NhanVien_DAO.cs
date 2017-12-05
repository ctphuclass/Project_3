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
    public  class NhanVien_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        //public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N0ORAA2\SQLEXPRESS;Initial Catalog=QLBanHangCaFe;Integrated Security=True");
        public static List<NhanVien_DTO> GetListNV()
        {
           
           
            try
            {
                List<NhanVien_DTO> Danhsach = new List<NhanVien_DTO>();
                NhanVien_DTO NV;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_GetListNV", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NV = new NhanVien_DTO();
                    NV.MaNV = reader["Ma_NV"].ToString();
                    NV.HoTenNV = reader["HoTen_NV"].ToString();
                    //NV.NgaySinh = DateTime.Parse(reader["NgaySinh"].ToString());
                    NV.NgaySinh = reader["NgaySinh"].ToString();
                    NV.GioiTinh = reader["GioiTinh"].ToString();
                    NV.QueQuan = reader["QueQuan"].ToString();
                    NV.DiaChi = reader["DiaChi"].ToString();
                    NV.Email = reader["Email"].ToString();
                    NV.SDT = reader["SoDienThoai"].ToString();
                    Danhsach.Add(NV);
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
        public static bool New_NV(NhanVien_DTO NhanVien_DTO)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_InsertNewNV @Ma_NV='{0}',@HoTen_NV=N'{1}',@NgaySinh='{2}',@GioiTinh=N'{3}',@QueQuan=N'{4}',@DiaChi=N'{5}',@Email='{6}',@SoDienThoai='{7}'",NhanVien_DTO.MaNV,NhanVien_DTO.HoTenNV,NhanVien_DTO.NgaySinh,NhanVien_DTO.GioiTinh,NhanVien_DTO.QueQuan,NhanVien_DTO.DiaChi,NhanVien_DTO.Email,NhanVien_DTO.SDT);
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
        public static bool Update_NV(NhanVien_DTO NhanVien_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                con.Open();
                //string Update = string.Format("EXEC proc_UpdateNV @Ma_NV='{0}',@Ma_NVmoi='{1}',@HoTen_NV=N'{2}',@NgaySinh='{3}',@GioiTinh=N'{4}',@QueQuan=N'{5}',@DiaChi=N'{6}',@Email='{7}',@SoDienThoai='{8}'", NhanVien_DTO.MaNV,NhanVien_DTO.MaNVmoi, NhanVien_DTO.HoTenNV, NhanVien_DTO.NgaySinh, NhanVien_DTO.GioiTinh, NhanVien_DTO.QueQuan, NhanVien_DTO.DiaChi, NhanVien_DTO.Email, NhanVien_DTO.SDT);
                string Update = string.Format("EXEC proc_UpdateNV @Ma_NV='{0}',@HoTen_NV=N'{1}',@NgaySinh='{2}',@GioiTinh=N'{3}',@QueQuan=N'{4}',@DiaChi=N'{5}',@Email='{6}',@SoDienThoai='{7}'",NhanVien_DTO.MaNV, NhanVien_DTO.HoTenNV, NhanVien_DTO.NgaySinh, NhanVien_DTO.GioiTinh, NhanVien_DTO.QueQuan, NhanVien_DTO.DiaChi, NhanVien_DTO.Email, NhanVien_DTO.SDT);
                SqlCommand cmd = new SqlCommand(Update, con);
                int i = cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                result.ResultCode = -1;
                result.ResultMessage_NV = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public static bool Delete_NV(NhanVien_DTO NhanVien_DTO)
        {
            try
            {
                con.Open();
                string Delete = string.Format("exec proc_DeleteNV @Ma_NV='{0}',@HoTen_NV=N'{1}',@NgaySinh='{2}',@GioiTinh=N'{3}',@QueQuan=N'{4}',@DiaChi=N'{5}',@Email='{6}',@SoDienThoai='{7}'", NhanVien_DTO.MaNV, NhanVien_DTO.HoTenNV, NhanVien_DTO.NgaySinh, NhanVien_DTO.GioiTinh, NhanVien_DTO.QueQuan, NhanVien_DTO.DiaChi, NhanVien_DTO.Email, NhanVien_DTO.SDT);
                SqlCommand cmd = new SqlCommand(Delete, con);
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
