using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromiumBrowser
{
    public partial class AdminForm : Form
    {
        DBCommunicator dbc = new DBCommunicator();
        public AdminForm()
        {
            InitializeComponent();
            UpdateView();
        }

        private void UpdateView()
        {
            dbc.ReadSiteShtEntries();

            for (int i = 0; i < dbc.siteArray.Count; i++)
            {
                siteShtTextArea.Text = siteShtTextArea.Text + "\n" + dbc.siteArray[i].ToString();

            }

            dbc.ReadUserShtEntries();

            for (int i = 0; i < dbc.userArray.Count; i++)
            {
                userShtTextArea.Text = userShtTextArea.Text + "\n" + dbc.userArray[i].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addWebsiteLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            idTextBox.Text = "";
        }
    }
}
