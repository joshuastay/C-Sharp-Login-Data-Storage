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
    public partial class editEntry : Form
    {
        List<LoginClass> userlogins = new List<LoginClass>();
        LoginClass entryToEdit;
        public editEntry()
        {
            InitializeComponent();
        }
        public editEntry(LoginClass tempData, List<LoginClass> listData)
        {
            userlogins = listData;
            entryToEdit = tempData;
            InitializeComponent();
            titleTextBox.Text = entryToEdit.name;
            userTextBox.Text = entryToEdit.getDecodedUser();
            passTextBox.Text = entryToEdit.getDecodedPass();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var changedName = titleTextBox.Text;
            var changedUser = userTextBox.Text;
            var changedPass = passTextBox.Text;

            if (string.IsNullOrWhiteSpace(changedName) || string.IsNullOrWhiteSpace(changedUser) || string.IsNullOrWhiteSpace(changedPass))
            {
                blankWarning formError = new blankWarning();
                formError.ShowDialog();
            }
            else
            {
                userlogins.Remove(entryToEdit);
                userlogins.Add(new LoginClass(changedUser, changedPass, changedName));
                this.Close();
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
