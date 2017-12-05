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
        public static bool Update_NV(NhanVien_DTO NhanVien_DTO)
        {
            return NhanVien_DAO.Update_NV(NhanVien_DTO);
        }
        public static bool Delete_NV(NhanVien_DTO NhanVien_DTO)
        {
            return NhanVien_DAO.Delete_NV(NhanVien_DTO);
        }

    }
}
