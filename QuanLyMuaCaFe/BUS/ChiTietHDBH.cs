using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietHDBH
    {
        public static List<ChiTietHDBH_DTO> Show_HDBH(ChiTietHDBH_DTO ChiTietHDBH_DTO)
        {
            return ChiTietHDBH_DAO.Show_HDBH(ChiTietHDBH_DTO);
        }
    }
}
