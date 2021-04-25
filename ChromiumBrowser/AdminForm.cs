using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ChromiumBrowser
{
    public partial class AdminForm : Form
    {
        private DBCommunicator dbc = new DBCommunicator();

        public AdminForm()
        {
            InitializeComponent();
            UpdateView();
        }

        private void UpdateView()
        {
            dbc.ReadSiteShtEntries();
            siteShtTextArea.Text = "";
            for(int i = 0; i < dbc.siteArray.Count; i++)
            {
                siteShtTextArea.Text = siteShtTextArea.Text + "\n" + dbc.siteArray[i].ToString();
            }

            dbc.ReadUserShtEntries();
            userShtTextArea.Text = "";
            for(int i = 0; i < dbc.userArray.Count; i++)
            {
                userShtTextArea.Text = userShtTextArea.Text + "\n" + dbc.userArray[i].ToString();
            }

            dbc.ReadWordShtEntries();
            wordShtTextArea.Text = "";
            for(int i = 0; i < dbc.wordArray.Count; i++)
            {
                wordShtTextArea.Text = wordShtTextArea.Text + "\n" + dbc.wordArray[i].ToString();
            }
        }

        private void addWebsite_Click(object sender, EventArgs e)
        {
            String url = urlTextBox.Text;
            String status = statusComboBox.Text;
            url = urlFormatter(url);

            if(siteShtTextArea.Text.Contains(url))
            {
                websiteStatusTextBox.Text = "Database already contains this URL.";
            }
            else
            {
                if(url.StartsWith("Not a valid"))
                {
                    websiteStatusTextBox.Text = url;
                }
                else if(status.Equals("Choose one"))
                {
                    websiteStatusTextBox.Text = "Please choose a status.";
                }
                else
                {
                    dbc.CreateWebsiteEntry(url, status);
                }
            }

            UpdateView();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }

        private String urlFormatter(String url)
        {
            if(url.StartsWith("https://"))
            {
                if(IsValidURL(url))
                {
                    return url;
                }
                else
                {
                    return "Not a valid URL. Please try to enter a new URL.";
                }
            }
            else if(url.StartsWith("http://"))
            {
                if(IsValidURL(url))
                {
                    return url;
                }
                else
                {
                    return "Not a valid URL. Please try to enter a new URL.";
                }
            }
            else if(url.StartsWith("www."))
            {
                url = "https://" + url;

                if(IsValidURL(url))
                {
                    return url;
                }
                else
                {
                    return "Not a valid URL. Please try to enter a new URL.";
                }
            }
            else
            {
                url = "https://www." + url;
                if(IsValidURL(url))
                {
                    return url;
                }
                else
                {
                    return "Not a valid URL. Please try to enter a new URL.";
                }
            }
        }

        private bool IsValidURL(string URL)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(URL);
        }

        private void wordSearchTextBox_Enter(object sender, EventArgs e)
        {
            wordSearchTextBox.Text = "";
        }

        private void wordSearchButton_Click(object sender, EventArgs e)
        {
            if(dbc.wordArray.Contains(wordSearchTextBox.Text))
            {
                wordSearchTextBox.Text = wordSearchTextBox.Text;
            }
            else
            {
                wordSearchTextBox.Text = "Word not found.";
            }
        }

        private void ipAddressTextBox_Enter(object sender, EventArgs e)
        {
            searchUserTextBox.Text = "";
        }

        private void urlTextBox_Enter(object sender, EventArgs e)
        {
            urlTextBox.Text = "";
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            UpdateView();
            String user = searchUserButton.Text;
            if(wordShtTextArea.Text.Contains(user))
            {
                //String ip = HttpContext.Current.Request.UserHostAddress;
                //dbc.CreateUserEntry();
                userStatusTextBox.Text = userStatusTextBox.Text + "Word is already in the database." + "\n";
            }
            else
            {
                userStatusTextBox.Text += "The word '" + searchUserTextBox.Text + "' was not found in database." + "\n";
            }
        }

        private void removeWebsiteTextBox_Enter(object sender, EventArgs e)
        {
            removeWebsiteTextBox.Text = "";
        }

        private void removeUserTextBox_Enter(object sender, EventArgs e)
        {
            removeUserTextBox.Text = "";
        }

        private void wordAddTextBox_Enter(object sender, EventArgs e)
        {
            wordAddTextBox.Text = "";
        }

        private void removeWordTextBox_Enter(object sender, EventArgs e)
        {
            removeWordTextBox.Text = "";
        }
    }
}