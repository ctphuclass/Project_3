using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ChiTietCongThuc_BUS
    {
        public static List<ChiTietCongThuc_DTO> ChiTietCongThuc(ChiTietCongThuc_DTO ChiTietCongThuc_DTO)
        {
            return ChiTietCongThuc_DAO.ChiTietCongThuc(ChiTietCongThuc_DTO);
        }
    }
}
