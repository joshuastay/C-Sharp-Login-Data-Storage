using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Login_Data_Storage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<LoginClass> userLogins = new List<LoginClass>();
            List<LoginClass> logincreds = new List<LoginClass>();

            LoginClass chase = new LoginClass("josh", "stay", "Chase");
            LoginClass capone = new LoginClass("britt", "stay", "cap one");

            logincreds.Add(capone);
            logincreds.Add(chase);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (userLogins.Count == 0)
            {
                Application.Run(new loginCreation(userLogins));
            }
            Application.Run(new appLogin(userLogins));

            if (appLogin.isLoggedIn)
            {
                Application.Run(new loginDataStorage(logincreds));
            }
        }
    }
}
