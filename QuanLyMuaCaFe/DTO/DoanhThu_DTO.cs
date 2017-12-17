using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhThu_DTO
    {
        public DateTime NgayDau { get; set; }
        public DateTime NgayCuoi { get; set; }
        public int TongDoanhThu { get; set; }
        public string MaHoaDon { get; set; }
        public string MaBan { get; set; }
        public int TongTien { get; set; }
        public string Error { get; set; }
    }
}
