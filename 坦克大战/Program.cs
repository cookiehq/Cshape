﻿using System;
using System.Windows.Forms;
//Download by http://www.codefans.net
namespace 坦克
{
    internal static class Program
    {
        /// <summary>
        ///   应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}