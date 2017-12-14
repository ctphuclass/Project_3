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
        public static List<NhanVien_DTO> GetListNV()
        {
            try
            {
                List<NhanVien_DTO> Danhsach = new List<NhanVien_DTO>();
                NhanVien_DTO NV;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_GetListNV", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NV = new NhanVien_DTO();
                    NV.MaNV = reader["Ma_NV"].ToString();
                    NV.HoTenNV = reader["HoTen_NV"].ToString();
                    NV.NgaySinh = DateTime.Parse( reader["NgaySinh"].ToString());
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
        public ResultMessage_DTO  Update_NV(NhanVien_DTO NhanVien_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ma_NV", NhanVien_DTO.MaNV);
                cmd.Parameters.AddWithValue("@HoTen_NV", NhanVien_DTO.HoTenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", NhanVien_DTO.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", NhanVien_DTO.GioiTinh);
                cmd.Parameters.AddWithValue("@QueQuan", NhanVien_DTO.QueQuan);
                cmd.Parameters.AddWithValue("@DiaChi", NhanVien_DTO.DiaChi);
                cmd.Parameters.AddWithValue("@Email", NhanVien_DTO.Email);
                cmd.Parameters.AddWithValue("@SoDienThoai", NhanVien_DTO.SDT);
                cmd.Parameters.AddWithValue("@pResultCode_NV", result.ResultCode_NV);
                cmd.Parameters.AddWithValue("@pResultMessage_NV", result.ResultMessage_NV);
                cmd.Parameters["@pResultCode_NV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NV"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NV = cmd.Parameters["@pResultCode_NV"].Value.ToString();
                result.ResultMessage_NV = cmd.Parameters["@pResultMessage_NV"].Value.ToString();
                cmd.Dispose();
                
            }
            catch (Exception ex)
            {
                result.ResultCode_NV = "";
                result.ResultMessage_NV = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public ResultMessage_DTO Delete_NV(NhanVien_DTO NhanVien_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ma_NV", NhanVien_DTO.MaNV);
                cmd.Parameters.AddWithValue("@HoTen_NV", NhanVien_DTO.HoTenNV);
                cmd.Parameters.AddWithValue("@NgaySinh", NhanVien_DTO.NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", NhanVien_DTO.GioiTinh);
                cmd.Parameters.AddWithValue("@QueQuan", NhanVien_DTO.QueQuan);
                cmd.Parameters.AddWithValue("@DiaChi", NhanVien_DTO.DiaChi);
                cmd.Parameters.AddWithValue("@Email", NhanVien_DTO.Email);
                cmd.Parameters.AddWithValue("@SoDienThoai", NhanVien_DTO.SDT);
                cmd.Parameters.AddWithValue("@pResultCode_NV", result.ResultCode_NV);
                cmd.Parameters.AddWithValue("@pResultMessage_NV", result.ResultMessage_NV);
                cmd.Parameters["@pResultCode_NV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NV"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NV"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NV = cmd.Parameters["@pResultCode_NV"].Value.ToString();
                result.ResultMessage_NV = cmd.Parameters["@pResultMessage_NV"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_NV = "";
                result.ResultMessage_NV = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return result;
        }
        public static List<NhanVien_DTO> Search_NV(NhanVien_DTO NhanVien_DTO)
        {
            List<NhanVien_DTO> Danhsach = new List<NhanVien_DTO>();
            NhanVien_DTO NV;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchNV", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchNV",'%'+NhanVien_DTO.MaNV+'%');
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
