using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class DoanhThu_BUS
    {
        public static List<DoanhThu_DTO> List_DoanhThu(DoanhThu_DTO DT)
        {
            return DoanhThu_DAO.List_DoanhThu(DT);
        }
        public static List<DoanhThu_DTO> TongDoanhThu(DoanhThu_DTO DT)
        {
            return DoanhThu_DAO.TongDoanhThu(DT);
        }
    }
}
