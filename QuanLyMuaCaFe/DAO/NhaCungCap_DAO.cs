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
    public class NhaCungCap_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public List<NhaCungCap_DTO> GetNccList()
        {
            List<NhaCungCap_DTO> Danhsach = new List<NhaCungCap_DTO>();
            NhaCungCap_DTO NCC;
            try
            {
                SqlCommand cmd = new SqlCommand("ds_NCC_GetNccList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NCC = new NhaCungCap_DTO();
                    NCC.MaNCC = reader["MaNCC"].ToString();
                    NCC.TenNCC = reader["TenNCC"].ToString();
                    NCC.DiaChi = reader["DiaChi"].ToString();
                    NCC.SoDienThoai = reader["SoDienThoai"].ToString();
                    Danhsach.Add(NCC);
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
        public static bool New_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_NewNCC @MaNCC = '{0}', @TenNCC=N'{1}',@DiaChi=N'{2}', @SDT='{3}'", NhaCungCap_DTO.MaNCC, NhaCungCap_DTO.TenNCC, NhaCungCap_DTO.DiaChi, NhaCungCap_DTO.SoDienThoai);
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
        public ResultMessage_DTO Update_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", NhaCungCap_DTO.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", NhaCungCap_DTO.TenNCC);
                cmd.Parameters.AddWithValue("@DiaChi", NhaCungCap_DTO.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", NhaCungCap_DTO.SoDienThoai);
                cmd.Parameters.AddWithValue("@pResultCode_NCC", result.ResultCode_NCC);
                cmd.Parameters.AddWithValue("@pResultMessage_NCC", result.ResultMessage_NCC);
                cmd.Parameters["@pResultCode_NCC"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NCC"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NCC"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NCC = cmd.Parameters["@pResultCode_NCC"].Value.ToString();
                result.ResultMessage_NCC = cmd.Parameters["@pResultMessage_NCC"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_NCC = "";
                result.ResultMessage_NCC = ex.Message;
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
        public ResultMessage_DTO Delete_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNCC", NhaCungCap_DTO.MaNCC);
                cmd.Parameters.AddWithValue("@TenNCC", NhaCungCap_DTO.TenNCC);
                cmd.Parameters.AddWithValue("@DiaChi", NhaCungCap_DTO.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", NhaCungCap_DTO.SoDienThoai);
                cmd.Parameters.AddWithValue("@pResultCode_NCC", result.ResultCode_NCC);
                cmd.Parameters.AddWithValue("@pResultMessage_NCC", result.ResultMessage_NCC);
                cmd.Parameters["@pResultCode_NCC"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NCC"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NCC"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NCC = cmd.Parameters["@pResultCode_NCC"].Value.ToString();
                result.ResultMessage_NCC = cmd.Parameters["@pResultMessage_NCC"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_NCC = "";
                result.ResultMessage_NCC = ex.Message;
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
        public static List<NhaCungCap_DTO> Search_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            List<NhaCungCap_DTO> Danhsach = new List<NhaCungCap_DTO>();
            NhaCungCap_DTO NCC;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchNCC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchNCC","%"+NhaCungCap_DTO.MaNCC+"%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NCC = new NhaCungCap_DTO();
                    NCC.MaNCC = reader["MaNCC"].ToString();
                    NCC.TenNCC = reader["TenNCC"].ToString();
                    NCC.DiaChi = reader["DiaChi"].ToString();
                    NCC.SoDienThoai = reader["SoDienThoai"].ToString();
                    Danhsach.Add(NCC);
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


