using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class Login_BUS
    {
        public ResultMessage_DTO SaveUserregisrationBL(Login_DTO Login_DTO) // passing Bussiness object Here
        {
            try
            {
                Login_DAO DangNhap = new Login_DAO(); // Creating object of Dataccess
                return DangNhap.AddUserDetails(Login_DTO); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public ResultMessage_DTO CheckUserLoginBL(Login_DTO Login_DTO)
        {
            try
            {
                Login_DAO DangNhap = new Login_DAO(); // Creating object of Dataccess
                return DangNhap.CheckUserLogin(Login_DTO); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
    }
}
