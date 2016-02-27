using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeOver_Paris
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

            string ConStr;

            try
            {
                ConStr = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Wedding", "Server", "").ToString();
            }
            catch (Exception)
            {

            }
            try
            {
                DAO.DBUtility.getConnection().Open();
                Application.Run(new Forms.FrmSplash());
            }
            catch (Exception)
            {
                Application.Run(new Forms.Configuration.FrmDatabaseConfiguration());   
            }
        }
    }
}
