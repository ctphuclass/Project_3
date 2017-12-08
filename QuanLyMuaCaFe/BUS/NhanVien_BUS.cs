using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhanVien_BUS
    {
        public List<NhanVien_DTO> GetListNV()
        {
            try
            {
                NhanVien_DAO NV_DAO = new NhanVien_DAO(); // Creating object of Dataccess
                return NhanVien_DAO.GetListNV(); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
        public static bool New_NV(NhanVien_DTO NhanVien_DTO)
        {
            return NhanVien_DAO.New_NV(NhanVien_DTO);
        }
        public ResultMessage_DTO Update_NV(NhanVien_DTO NhanVien_DTO)
        {
            try
            {
                NhanVien_DAO NhanVien_DAO = new NhanVien_DAO();
                return NhanVien_DAO.Update_NV(NhanVien_DTO);
            }
            catch
            {
                throw;
            }    
        }
        public ResultMessage_DTO Delete_NV(NhanVien_DTO NhanVien_DTO)
        {
            try
            {
                NhanVien_DAO NhanVien_DAO = new NhanVien_DAO();
                return NhanVien_DAO.Delete_NV(NhanVien_DTO);
            }
            catch
            {
                throw;
            }
        }
        public static List<NhanVien_DTO> Search_NV(NhanVien_DTO NhanVien_DTO)
        {
            NhanVien_DAO NhanVien_DAO = new NhanVien_DAO();
            return NhanVien_DAO.Search_NV(NhanVien_DTO);
        }
    }
}
