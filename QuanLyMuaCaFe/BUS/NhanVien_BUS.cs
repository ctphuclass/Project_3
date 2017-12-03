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
                return NV_DAO.GetListNV(); // calling Method of DataAccess
            }
            catch
            {
                throw;
            }
        }
    }
}
