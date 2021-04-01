using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login_Data_Storage
{
    public partial class loginDataStorage : Form
    {
        List<LoginClass> userlogins = new List<LoginClass>();
        editEntry editForm = new editEntry();
        public loginDataStorage(List<LoginClass> credentials)
        {
            userlogins = credentials;
            InitializeComponent();
            comboBox1.DataSource = userlogins;
            comboBox1.DisplayMember = "name";
        }



        private void userLabelDisplay_Click(object sender, EventArgs e)
        {

        }

        private void userDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoginClass tempselected = (LoginClass)comboBox1.SelectedItem;

            if (tempselected != null)
            {
                userDisplayLabel.Text = tempselected.getDecodedUser();
                passDisplayLabel.Text = tempselected.getDecodedPass();
            }
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            addNew newForm = new addNew(userlogins);
            newForm.ShowDialog();
            comboRefresh();
        }

        private void comboRefresh()
        {
            comboBox1.DataSource = null;
            comboBox1.Items.Clear();
            comboBox1.DataSource = userlogins;
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedIndex = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editEntry editForm = new editEntry((LoginClass)comboBox1.SelectedItem, userlogins);
            editForm.ShowDialog();
            comboRefresh();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passLabelDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
