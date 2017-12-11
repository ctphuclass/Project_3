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
    public class Menu_DAO
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        public static List<Menu_DTO> GetListMenu()
        {
            try
            {
                List<Menu_DTO> Danhsach = new List<Menu_DTO>();
                Menu_DTO Menu;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec proc_GetListMenu", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Menu = new Menu_DTO();
                    Menu.MaMon = reader["MaMon"].ToString();
                    Menu.TenMon = reader["TenMon"].ToString();
                    Menu.Loai = reader["Loai"].ToString();
                    Menu.DonGia = Int32.Parse(reader["DonGia"].ToString());
                    Menu.DVT = reader["DVT"].ToString();
                    Menu.SLN = Int32.Parse(reader["SLN"].ToString());
                    Menu.SLT = Int32.Parse(reader["SLT"].ToString());
                    Danhsach.Add(Menu);
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
        public static bool New_Nenu(Menu_DTO Menu_DTO)
        {
            try
            {
                con.Open();
                string New = string.Format("exec proc_NewMenu @MaMon='{0}',@TenMon=N'{1}',@Loai=N'{2}',@DonGia={3},@DVT=N'{4}',@SLN={5},@SLT={6}", Menu_DTO.MaMon, Menu_DTO.TenMon, Menu_DTO.Loai, Menu_DTO.DonGia, Menu_DTO.DVT, Menu_DTO.SLN, Menu_DTO.SLT);
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
        public ResultMessage_DTO Update_Menu(Menu_DTO Menu_DTO)
        {

            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_UpdateMenu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaMon", Menu_DTO.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", Menu_DTO.TenMon);
                cmd.Parameters.AddWithValue("@Loai", Menu_DTO.Loai);
                cmd.Parameters.AddWithValue("@DonGia", Menu_DTO.DonGia);
                cmd.Parameters.AddWithValue("@DVT", Menu_DTO.DVT);
                cmd.Parameters.AddWithValue("@SLN", Menu_DTO.SLN);
                cmd.Parameters.AddWithValue("@SLT", Menu_DTO.SLT);
                cmd.Parameters.AddWithValue("@pResultCode_Menu", result.ResultCode_Menu);
                cmd.Parameters.AddWithValue("@pResultMessage_Menu", result.ResultMessage_Menu);
                cmd.Parameters["@pResultCode_Menu"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_Menu"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_Menu"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                //result.ResultCode_Menu = cmd.Parameters["@MaMon"].Value.ToString();
                result.ResultCode_Menu = cmd.Parameters["@pResultCode_Menu"].Value.ToString();
                result.ResultMessage_Menu = cmd.Parameters["@pResultMessage_Menu"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_Menu = "";
                result.ResultMessage_Menu = ex.Message;
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
        public ResultMessage_DTO Delete_Menu(Menu_DTO Menu_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DeleteMenu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaMon", Menu_DTO.MaMon);
                cmd.Parameters.AddWithValue("@TenMon", Menu_DTO.TenMon);
                cmd.Parameters.AddWithValue("@Loai", Menu_DTO.Loai);
                cmd.Parameters.AddWithValue("@DonGia", Menu_DTO.DonGia);
                cmd.Parameters.AddWithValue("@DVT", Menu_DTO.DVT);
                cmd.Parameters.AddWithValue("@SLN", Menu_DTO.SLN);
                cmd.Parameters.AddWithValue("@SLT", Menu_DTO.SLT);
                cmd.Parameters.AddWithValue("@pResultCode_Menu", result.ResultCode_Menu);
                cmd.Parameters.AddWithValue("@pResultMessage_Menu", result.ResultMessage_Menu);
                cmd.Parameters["@pResultCode_Menu"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_Menu"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage_Menu"].Size = 200;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode_Menu = cmd.Parameters["@pResultCode_Menu"].Value.ToString();
                result.ResultMessage_Menu = cmd.Parameters["@pResultMessage_Menu"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode_Menu = "";
                result.ResultMessage_Menu = ex.Message;
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
        public static List<Menu_DTO> Search_Menu(Menu_DTO Menu_DTO)
        {
            List<Menu_DTO> Danhsach = new List<Menu_DTO>();
            Menu_DTO Menu;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("proc_SearchMenu", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchMenu", Menu_DTO.MaMon);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Menu = new Menu_DTO();
                    Menu.MaMon = reader["MaMon"].ToString();
                    Menu.TenMon = reader["TenMon"].ToString();
                    Menu.Loai = reader["Loai"].ToString();
                    Menu.DonGia = Int32.Parse(reader["DonGia"].ToString());
                    Menu.DVT = reader["DVT"].ToString();
                    Menu.SLN = Int32.Parse(reader["SLN"].ToString());
                    Menu.SLT = Int32.Parse(reader["SLT"].ToString());
                    Danhsach.Add(Menu);
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
