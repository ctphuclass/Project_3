using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HDBanHang_BUS
    {
        public static List<HDBanHang_DTO> GetListHDBH()
        {
            try
            {
                return HDBanHang_DAO.GetListHDBH();
            }
            catch
            {
                throw;
            }
        }
        public static List<HDBanHang_DTO> Search_HDBH(HDBanHang_DTO HDBanHang_DTO)
        {
            return HDBanHang_DAO.Search_HDBH(HDBanHang_DTO);
        }
        //public static List<ChiTietHDBH_DTO> Get_CTHD(ChiTietHDBH_DTO HDBanHang_DTO)
        //{
        //    return HDBanHang_DAO.Get_CTHD(HDBanHang_DTO);
        //}
    }
}
