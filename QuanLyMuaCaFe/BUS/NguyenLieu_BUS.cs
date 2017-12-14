using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NguyenLieu_BUS
    {
        public static List<NguyenLieu_DTO> GetListNL()
        {
            return NguyenLieu_DAO.GetListNL();
        }
        public static bool New_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            return NguyenLieu_DAO.New_NL(NguyenLieu_DTO);
        }
        public static ResultMessage_DTO Update_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            NguyenLieu_DAO NL_DAO = new NguyenLieu_DAO();
            return NL_DAO.Update_NL(NguyenLieu_DTO);
        }
        public static ResultMessage_DTO Delete_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            NguyenLieu_DAO NL_DAO = new NguyenLieu_DAO();
            return NL_DAO.Delete_NL(NguyenLieu_DTO);
        }
        public static List<NguyenLieu_DTO> Search_NL(NguyenLieu_DTO NguyenLieu_DTO)
        {
            return NguyenLieu_DAO.Search_NL(NguyenLieu_DTO);
        }
    }
}
