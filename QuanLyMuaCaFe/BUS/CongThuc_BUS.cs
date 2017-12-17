using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CongThuc_BUS
    {
        public static List<CongThuc_DTO> GetListCongThuc()
        {
            return CongThuc_DAO.GetListCongThuc();
        }
        public static List<CongThuc_DTO> Search_CongThuc(CongThuc_DTO CongThuc_DTO)
        {
            return CongThuc_DAO.Search_CongThuc(CongThuc_DTO);
        } 
    }
}
