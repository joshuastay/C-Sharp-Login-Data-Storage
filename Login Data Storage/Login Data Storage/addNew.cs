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
    public partial class addNew : Form
    {
        List<LoginClass> userlogins = new List<LoginClass>();
        public addNew(List<LoginClass> credentials)
        {
            userlogins = credentials;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var tempName = titleTextBox.Text;
            var tempUser = userTextBox.Text;
            var tempPass = passTextBox.Text;

            if (string.IsNullOrWhiteSpace(tempUser) || string.IsNullOrWhiteSpace(tempPass) || string.IsNullOrWhiteSpace(tempName))
            {
                blankWarning formError = new blankWarning();
                formError.ShowDialog();
            }
            else
            {
                userlogins.Add(new LoginClass(tempUser, tempPass, tempName));
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
