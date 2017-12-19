using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDonNhapHang_BUS
    {
        public static List<HoaDonNhapHang_DTO> GetListHDNH()
        {
            return HoaDonNhapHang_DAO.GetListHDNH();
        }
        public static List<HoaDonNhapHang_DTO> Search_HDBH(HoaDonNhapHang_DTO HoaDonNhapHang_DTO)
        {
            return HoaDonNhapHang_DAO.Search_HDBH(HoaDonNhapHang_DTO);
        }
    }
}
