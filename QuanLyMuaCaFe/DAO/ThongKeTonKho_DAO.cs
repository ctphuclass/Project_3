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
    public class ThongKeTonKho_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public List<ThongKeTonKho_DTO> LoadTonKho()
        {
            List<ThongKeTonKho_DTO> TK = new List<ThongKeTonKho_DTO>();
            ThongKeTonKho_DTO TonKho;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_LoadTonKho", con);
                cmd.CommandType = CommandType.StoredProcedure;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TonKho = new ThongKeTonKho_DTO();
                    TonKho.MaMon = reader["MaMon"].ToString();
                    TonKho.MaNL = reader["MaNL"].ToString();
                    TonKho.TenNL = (reader["TenNL"].ToString());
                    TonKho.SoLuongNhap = Int32.Parse(reader["SoLuongNhap"].ToString());
                    TonKho.SoLuongTon = float.Parse(reader["SoLuongTon"].ToString());
                    TK.Add(TonKho);
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
            return TK;
        }
        public static List<ThongKeTonKho_DTO> TinhTonKho(ThongKeTonKho_DTO ThongKeTonKho_DTO)
        {
            List<ThongKeTonKho_DTO> Danhsach = new List<ThongKeTonKho_DTO>();
            ThongKeTonKho_DTO TK;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_TonKho", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TenNL", ThongKeTonKho_DTO.TenNL);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TK = new ThongKeTonKho_DTO();
                    TK.TenNL = reader["TenNL"].ToString();
                    TK.SoLuongTon = float.Parse(reader["SoLuongTon"].ToString());
                    Danhsach.Add(TK);
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
