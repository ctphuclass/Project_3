using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultMessage_DTO
    {
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        public ResultMessage_DTO()
        {
            ResultCode = -1;
            ResultMessage = "DEFAULTERROR";
        }
    }
}
