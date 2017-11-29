using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhaCungCap_BUS
    {
        public List<NhaCungCap_DTO> GetNccList()
        {
            try
            {
                NhaCungCap_DAO NCC_DAO = new NhaCungCap_DAO(); // Creating object of Dataccess
                return NCC_DAO.GetNccList(); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public static bool New_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.New_NCC(NhaCungCap_DTO);
        }
        public static bool Update_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.Update_NCC(NhaCungCap_DTO);
        }
        public static bool Delete_NCC(NhaCungCap_DTO NhaCungCap_DTO)
        {
            return NhaCungCap_DAO.Delete_NCC(NhaCungCap_DTO);
        }
    }
}
