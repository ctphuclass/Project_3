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
    public class Login_DAO
    {
        //Kết nối Database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        //Kiểm tra tài khoản user có tồn tại hay ko
        public ResultMessage_DTO AddUserDetails(Login_DTO ObjBO) // passing Bussiness object Here
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
				To in Bussiness object and then Pass it to Bussiness logic and then to
				DataAcess
				this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("usp_USER_CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@psUsername", ObjBO.UserName);
                cmd.Parameters.AddWithValue("@psPassword", ObjBO.PassWord);
                cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
                cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
                cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Size = 50;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
                result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode = -1;
                result.ResultMessage = ex.Message;
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
        //Kiểm tra check User đăng nhập thành công hay không
        public ResultMessage_DTO CheckUserLogin(Login_DTO Login_DTO)
        {
            ResultMessage_DTO result = new ResultMessage_DTO();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_USER_CheckUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@psUsername", Login_DTO.UserName);
                cmd.Parameters.AddWithValue("@psPassword", Login_DTO.PassWord);
                cmd.Parameters.AddWithValue("@pResultCode", result.ResultCode);
                cmd.Parameters.AddWithValue("@pResultMessage", result.ResultMessage);
                cmd.Parameters["@pResultCode"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Direction = ParameterDirection.Output;
                cmd.Parameters["@pResultMessage"].Size = 50;
                con.Open();
                cmd.ExecuteNonQuery();
                result.ResultCode = (int)cmd.Parameters["@pResultCode"].Value;
                result.ResultMessage = cmd.Parameters["@pResultMessage"].Value.ToString();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                result.ResultCode = -1;
                result.ResultMessage = ex.Message;
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
        public List<Login_DTO> GetPermission(Login_DTO piUserID,Login_DTO psQuyen)
        {
            List<Login_DTO> list = new List<Login_DTO>();
            Login_DTO user;
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
				To in Bussiness object and then Pass it to Bussiness logic and then to
				DataAcess
				this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("usp_USER_GetUserPermision", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@piUserID", piUserID);
                cmd.Parameters.AddWithValue("@psQuyen", psQuyen);
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user = new Login_DTO();
                    user.UserID = int.Parse(reader["UserID"].ToString());
                    user.Quyen = reader["Quyen"].ToString();
                    list.Add(user);
                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                list = null;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return list;
        }
    }
}
