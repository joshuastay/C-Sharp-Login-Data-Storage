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
    public partial class loginDataStorage : Form
    {
        List<LoginClass> userlogins = new List<LoginClass>();
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

            userDisplayLabel.Text = tempselected.getDecodedUser();
            passDisplayLabel.Text = tempselected.getDecodedPass();

        }
    }
}
