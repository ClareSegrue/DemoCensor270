using System;
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
    public partial class AdminLoginForm : Form
    {
        String user = "user";
        String pass = "pass";

        public AdminLoginForm()
        {
            InitializeComponent();
            
        }

        private void loginButton_click(object sender, EventArgs e)
        {
            if(usernameBox.Text.Equals(user) && passwordBox.Text.Equals(pass))
            {
                Form.ActiveForm.Close();
                AdminForm af = new AdminForm();
                af.Show();
                if (af.DialogResult == DialogResult.OK) {
                    Console.Write("Login Accepted");  
                 } else {
                    Console.Write("Login Failed");
                }
            } 
        }
    }
}
