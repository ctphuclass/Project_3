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
    public class NguyenLieu_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<NguyenLieu_DTO> GetListNL()
        {
            List<NguyenLieu_DTO> Danhsach = new List<NguyenLieu_DTO>();
            NguyenLieu_DTO NL;
            try
            {
                SqlCommand cmd = new SqlCommand("proc_GetListNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NL = new NguyenLieu_DTO();
                    NL.MaNL = reader["MaNL"].ToString();
                    //NL.MaMon = reader["MaMon"].ToString();
                    NL.TenNL = reader["TenNL"].ToString();
                    NL.SoLuongNhap = Int32.Parse(reader["SoLuongNhap"].ToString());
                    NL.DVT = (reader["DVT"].ToString());
                    Danhsach.Add(NL);
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
        public static bool New_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_NewNL @MaNL='{0}',@TenNL=N'{1}',@SoLuongNhap='{2}',@DVT=N'{3}'", NguyenLieu_DTO.MaNL, NguyenLieu_DTO.TenNL, NguyenLieu_DTO.SoLuongNhap, NguyenLieu_DTO.DVT);
                SqlCommand cmd = new SqlCommand(New, con);//@MaNL,@TenNL,@SoLuongNhap,@DVT
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
        public ResultMessage_DTO Update_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", NguyenLieu_DTO.MaNL);
                cmd.Parameters.AddWithValue("@TenNL", NguyenLieu_DTO.TenNL);
                cmd.Parameters.AddWithValue("@SoLuongNhap", NguyenLieu_DTO.SoLuongNhap);
                cmd.Parameters.AddWithValue("@DVT", NguyenLieu_DTO.DVT);
                cmd.Parameters.AddWithValue("@pResultCode_NL", result.ResultCode_NL);
                cmd.Parameters.AddWithValue("@pResultMessage_NL", result.ResultMessage_NL);
                cmd.Parameters["@pResultCode_NL"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NL"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NL"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NL = Int32.Parse(cmd.Parameters["@pResultCode_NL"].Value.ToString());
                result.ResultMessage_NL = cmd.Parameters["@pResultMessage_NL"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_NL = -1;
                result.ResultMessage_NL = ex.Message;
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
        public ResultMessage_DTO Delete_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNL", NguyenLieu_DTO.MaNL);
                cmd.Parameters.AddWithValue("@TenNL", NguyenLieu_DTO.TenNL);
                cmd.Parameters.AddWithValue("@SoLuongNhap", NguyenLieu_DTO.SoLuongNhap);
                cmd.Parameters.AddWithValue("@DVT", NguyenLieu_DTO.DVT);
                cmd.Parameters.AddWithValue("@pResultCode_NL", result.ResultCode_NL);
                cmd.Parameters.AddWithValue("@pResultMessage_NL", result.ResultMessage_NL);
                cmd.Parameters["@pResultCode_NL"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NL"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_NL"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_NL = Int32.Parse(cmd.Parameters["@pResultCode_NL"].Value.ToString());
                result.ResultMessage_NL = cmd.Parameters["@pResultMessage_NL"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_NL = -1;
                result.ResultMessage_NL = ex.Message;
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
        public static List<NguyenLieu_DTO> Search_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            List<NguyenLieu_DTO> Danhsach = new List<NguyenLieu_DTO>();
            NguyenLieu_DTO NL;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchNL", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchNL", '%' + NguyenLieu_DTO.MaNL + '%');
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NL = new NguyenLieu_DTO();
                    NL.MaNL = reader["MaNL"].ToString();
                    NL.TenNL = reader["TenNL"].ToString();
                    NL.SoLuongNhap = Int32.Parse(reader["SoLuongNhap"].ToString());
                    NL.DVT = (reader["DVT"].ToString());
                    Danhsach.Add(NL);
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
