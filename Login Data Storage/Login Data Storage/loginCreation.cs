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
    public partial class loginCreation : Form
    {
        List<LoginClass> newLogs = new List<LoginClass>();
        public loginCreation(List<LoginClass> loginlist)
        {
            InitializeComponent();
            newLogs = loginlist;
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {
            string tempUser = userBox.Text;
            string tempPass = passBox.Text;

            if (string.IsNullOrWhiteSpace(tempUser) || string.IsNullOrWhiteSpace(tempPass))
            {
                blankWarning formError = new blankWarning();
                formError.ShowDialog();
            }
            else
            {
                newLogs.Add(new LoginClass(tempUser, tempPass));
                this.Close();
            }
        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
