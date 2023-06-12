using GUI;
using System;
using System.Windows.Forms;

namespace QuanLySuaChuaXe_LinQ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FM_QuanLySuaChuaXe());
        }
    }
}
