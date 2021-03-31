using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Data_Storage
{
    public partial class appLogin : Form
    {
        List<LoginClass> credentials = new List<LoginClass>();
        public static bool isLoggedIn = false;
        public appLogin(List<LoginClass> users)
        {
            InitializeComponent();
            credentials = users;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            string tempUser = "";
            string tempPass = "";

            foreach (LoginClass n in credentials)
            {
                tempUser = n.getDecodedUser();
                
                if (tempUser == username)
                {
                    tempPass = n.getDecodedPass();
                    break;
                }
            }

            if (tempUser == username && tempPass == password)
            {
                isLoggedIn = true;
                
            }
            else
            {
                incorrectWarning wrongWarn = new incorrectWarning();
                wrongWarn.ShowDialog();
            }
            if (isLoggedIn)
            {
                this.Close();
            }
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
