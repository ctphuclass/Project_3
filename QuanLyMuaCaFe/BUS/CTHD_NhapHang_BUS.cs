using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class CTHD_NhapHang_BUS
    {
        public static List<CTHD_NhapHang_DTO> Show_HDNH(CTHD_NhapHang_DTO CTHD_NhapHang_DTO)
        {
            return CTHD_NhapHang_DAO.Show_HDNH(CTHD_NhapHang_DTO);
        }
    }
}
