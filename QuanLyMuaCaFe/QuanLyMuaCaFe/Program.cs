﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMuaCaFe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmLogin fLogin = new frmLogin();
            //fLogin.ShowDialog();
            //if(fLogin.UserID > 0)
            //{
            //    frmView fView = new frmView();
            //    fView.UserID = fLogin.UserID;
                Application.Run(new frmLogin());
            //}
            
        }
    }
}
