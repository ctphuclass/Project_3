using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class Menu_BUS
    {
        public List<Menu_DTO> GetListMenu()
        {
            try
            {
                Menu_DAO Menu_DAO = new Menu_DAO(); 
                return Menu_DAO.GetListMenu();
            }
            catch
            {
                throw;
            }
        }
        public static bool New_Nenu(Menu_DTO Menu_DTO)
        {
            return Menu_DAO.New_Nenu(Menu_DTO);
        }
        public ResultMessage_DTO Update_Menu(Menu_DTO Menu_DTO)
        {
            try
            {
                Menu_DAO Menu_DAO = new Menu_DAO();
                return Menu_DAO.Update_Menu(Menu_DTO);
            }
            catch
            {
                throw;
            }
        }
        public ResultMessage_DTO Delete_Menu(Menu_DTO Menu_DTO)
        {
            try
            {
                Menu_DAO Menu_DAO = new Menu_DAO();
                return Menu_DAO.Delete_Menu(Menu_DTO);
            }
            catch
            {
                throw;
            }
        }
        public static List<Menu_DTO> Search_Menu(Menu_DTO Menu_DTO)
        {
            Menu_DAO Menu_DAO = new Menu_DAO();
            return Menu_DAO.Search_Menu(Menu_DTO);
        }
    }
}
