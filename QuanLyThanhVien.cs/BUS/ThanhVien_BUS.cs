using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ThanhVien_BUS
    {
        public static List<ThanhVien_DTO> GetListTV()
        {
            return ThanhVien_DAO.GetListTV();
        }
        public static bool New_TV(ThanhVien_DTO ThanhVien_DTO)
        {
            return ThanhVien_DAO.New_TV(ThanhVien_DTO);
        }
    }
}
