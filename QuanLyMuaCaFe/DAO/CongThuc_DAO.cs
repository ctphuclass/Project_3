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
    public class CongThuc_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<CongThuc_DTO> GetListCongThuc()
        {
            List<CongThuc_DTO> Danhsach = new List<CongThuc_DTO>();
            try
            {
                CongThuc_DTO CongThuc;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_LoadCongThuc", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CongThuc = new CongThuc_DTO();
                    CongThuc.MaNL = reader["MaNL"].ToString();
                    CongThuc.TenNL = reader["TenNL"].ToString();
                    CongThuc.MaMon = reader["MaMon"].ToString();
                    CongThuc.HamLuong = float.Parse(reader["HamLuong"].ToString());
                    CongThuc.DVT = reader["DVT"].ToString();
                    Danhsach.Add(CongThuc);
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
        public static List<CongThuc_DTO> Search_CongThuc(CongThuc_DTO CongThuc_DTO)
        {
            List<CongThuc_DTO> Danhsach = new List<CongThuc_DTO>();
            CongThuc_DTO CongThuc;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchCongThuc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchCongThuc", "%" + CongThuc_DTO.MaNL + "%");
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CongThuc = new CongThuc_DTO();
                    CongThuc.MaNL = reader["MaNL"].ToString();
                    CongThuc.TenNL = reader["TenNL"].ToString();
                    CongThuc.MaMon = reader["MaMon"].ToString();
                    CongThuc.HamLuong = float.Parse(reader["HamLuong"].ToString());
                    CongThuc.DVT = reader["DVT"].ToString();
                    Danhsach.Add(CongThuc);
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
