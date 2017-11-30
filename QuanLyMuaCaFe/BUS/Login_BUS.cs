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

        public List<Login_DTO> GetPermission(object piUserID, string v)
        {
            throw new NotImplementedException();
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
        public List<Login_DTO> GetPermission(Login_DTO piUserID, Login_DTO psQuyen)
        {
            try
            {
                Login_DAO Quyen = new Login_DAO(); // Creating object of Dataccess
                return Quyen.GetPermission(piUserID, psQuyen); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
    }
}
