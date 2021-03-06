﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ResultMessage_DTO
    {
        //Khai báo giá trị kết quả cho frm Login
        public int ResultCode { get; set; }
        public string ResultMessage { get; set; }
        //Khai báo giá trị kết quả cho frmQuanLyNhanVien
        public string ResultCode_NV { get; set; }
        public string ResultMessage_NV { get; set; }
        //Khai báo giá trị kết quả cho frmQuanLyNCC
        public string ResultCode_NCC { get; set; }
        public string ResultMessage_NCC { get; set; }
        //Khai báo giá trị kết quả cho frmMenu
        public string ResultCode_Menu { get; set; }
        public string ResultMessage_Menu { get; set; }
        //Khai báo giá trị kết quả cho frmNguyenLieu
        public int ResultCode_NL { get; set; }
        public string ResultMessage_NL { get; set; }

        public ResultMessage_DTO()
        {   //frmLogin giá trị trả về thành công hay thất bại
            ResultCode = -1;
            ResultMessage = "DEFAULTERROR";
            //frmQuanLyNhanVien giá trị trả về thành công hay thất bại
            ResultCode_NV = "-1";
            ResultMessage_NV = "DEFAULTERROR";
            //frmQuanLyNCC giá trị trả về thành công hay thất bại
            ResultCode_NCC = "-1";
            ResultMessage_NCC = "DEFAULTERROR";
            //frmMenu giá trị trả về thành công hay thất bại
            ResultCode_Menu = "-1";
            ResultMessage_Menu = "DEFAULTERROR";
            //frmMenu giá trị trả về thành công hay thất bại
            ResultCode_NL = -1;
            ResultMessage_NL = "DEFAULTERROR";
        }
    }
}
