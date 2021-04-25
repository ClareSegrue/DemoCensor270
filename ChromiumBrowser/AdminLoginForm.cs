using System;
using System.Windows.Forms;

namespace ChromiumBrowser
{
    public partial class AdminLoginForm : Form
    {
        private String user = "user";
        private String pass = "pass";

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
                if(af.DialogResult == DialogResult.OK)
                {
                    Console.Write("Login Accepted");
                }
                else
                {
                    Console.Write("Login Failed");
                }
            }
        }
    }
}