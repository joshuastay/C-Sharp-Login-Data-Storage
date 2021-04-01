using System;
using System.IO;
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

            //looks for data file in the root directory of the app, if present it reads the file and adds the data to a list
            if (Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).Contains(AppDomain.CurrentDomain.BaseDirectory + "applogex.bin"))
            {
                userLogins = BinarySerialization.ReadFromBinaryFile<List<LoginClass>>(AppDomain.CurrentDomain.BaseDirectory + "applogex.bin");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //checks for previous user logins, if none are present it will write the login that was created to a binary file
            if (userLogins.Count == 0)
            {
                Application.Run(new loginCreation(userLogins));
                BinarySerialization.WriteToBinaryFile<List<LoginClass>>(AppDomain.CurrentDomain.BaseDirectory + "applogex.bin", userLogins);
            }

            //once a login has been created or loaded, the main login screen appears
            if (userLogins.Count > 0)
            {
                Application.Run(new appLogin(userLogins));
            }

            // after successful login the main app is now loaded
            if (appLogin.isLoggedIn)
            {
                if (Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory).Contains(AppDomain.CurrentDomain.BaseDirectory + "applogdat.bin"))
                {
                    logincreds = BinarySerialization.ReadFromBinaryFile<List<LoginClass>>(AppDomain.CurrentDomain.BaseDirectory + "applogdat.bin");
                }
                var mainApp = new loginDataStorage(logincreds);
                mainApp.ShowDialog();
                BinarySerialization.WriteToBinaryFile<List<LoginClass>>(AppDomain.CurrentDomain.BaseDirectory + "applogdat.bin", logincreds);
            }
        }
    }
}
