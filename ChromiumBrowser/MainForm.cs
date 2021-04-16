using CefSharp;
using CefSharp.WinForms;
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

    public partial class MainForm : Form
    {
        ChromiumWebBrowser chrome;
        DBCommunicator dbc = new DBCommunicator();


        public MainForm()
        {  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings settings = new CefSettings();
   
            //Init
            Cef.Initialize(settings);
            urlTextBox.Text = "https://www.google.com";
            chrome = new ChromiumWebBrowser(urlTextBox.Text);
            this.pContainer.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressedChanged;
            chrome.FrameLoadEnd += Chrome_FrameLoadEnd;

        }

        private void Chrome_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            String random = "democracy";
            
            string cleanupCommand = "document.body.innerHTML = document.body.innerHTML.replace(/" + random + "/gi, '***');";

            this.chrome.ExecuteScriptAsyncWhenPageLoaded(cleanupCommand);

           
        }

        private void Chrome_AddressedChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(()=>
                {
                urlTextBox.Text = e.Address;
            }));
        }

        private void goButton_Click(object sender, EventArgs e)
        {
           
            chrome.Load(urlTextBox.Text);
            dbc.ReadSiteShtEntries();
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (chrome.CanGoBack)
            {
                chrome.Back();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            AdminLoginForm dlg = new AdminLoginForm();
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Test");
            }          
        }
    }
}
