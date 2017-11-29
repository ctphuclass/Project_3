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
        public static bool Update_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {

            try
            {
                con.Open();
                string Update = string.Format("exec proc_UpdateNCC @MaNCC = '{0}', @TenNCC=N'{1}',@DiaChi=N'{2}', @SDT='{3}'", NhaCungCap_DTO.MaNCC, NhaCungCap_DTO.TenNCC, NhaCungCap_DTO.DiaChi, NhaCungCap_DTO.SoDienThoai);
                SqlCommand cmd = new SqlCommand(Update, con);
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
        public static bool Delete_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            try
            {
                con.Open();
                string Delete = string.Format("exec proc_DeleteNCC @MaNCC = '{0}', @TenNCC=N'{1}',@DiaChi=N'{2}', @SDT='{3}'", NhaCungCap_DTO.MaNCC, NhaCungCap_DTO.TenNCC, NhaCungCap_DTO.DiaChi, NhaCungCap_DTO.SoDienThoai);
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


