using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ThongKeTonKho_BUS
    {
        public List<ThongKeTonKho_DTO> LoadTonKho()
        {
            ThongKeTonKho_DAO TK = new ThongKeTonKho_DAO();
            return TK.LoadTonKho();
        }
        public static List<ThongKeTonKho_DTO> TinhTonKho(ThongKeTonKho_DTO ThongKeTonKho_DTO)
        {
            return ThongKeTonKho_DAO.TinhTonKho(ThongKeTonKho_DTO);
        }
    }
}
