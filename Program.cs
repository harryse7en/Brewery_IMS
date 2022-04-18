using Brewery_IMS.Classes;
using System;
using System.Windows.Forms;

namespace Brewery_IMS
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
            Application.Run(FormMgr.Main);
        }
    }
}
