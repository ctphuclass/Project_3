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
    public class ChiTietCongThuc_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<ChiTietCongThuc_DTO> ChiTietCongThuc(ChiTietCongThuc_DTO ChiTietCongThuc_DTO)
        {
            List<ChiTietCongThuc_DTO> Danhsach = new List<ChiTietCongThuc_DTO>();
            ChiTietCongThuc_DTO CTCT;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_CTCT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaMon", ChiTietCongThuc_DTO.MaMon);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CTCT = new ChiTietCongThuc_DTO();
                    CTCT.MaMon = reader["MaMon"].ToString();
                    CTCT.MaNL = reader["MaNL"].ToString();
                    CTCT.TenNL = (reader["TenNL"].ToString());
                    CTCT.HamLuong = float.Parse(reader["HamLuong"].ToString());
                    CTCT.DVT = (reader["DVT"].ToString());
                    Danhsach.Add(CTCT);
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
