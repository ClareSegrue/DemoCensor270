using CefSharp;
using CefSharp.WinForms;
using HtmlAgilityPack;
using System;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

/**
 * Next group-- This project may seem overwhelming at first, but it's actually pretty straightforward. I'll do my best to explain in these comments.
 *
 * To make our browser, we used something called CefSharp. When you open this project, you likely will not have this package installed. 
 * To have this program work, you will need to install a few packages -- CefSharp, Google Sheets API and something called an HTML Agility Pack. 
 * 
 * Go to 'Tools > NuGet Package Manager > Manage NuGet Packages for Solution > Browse'
 * From here, you should be able to install these packages:
 *      -CefSharp.WinForms
 *      -Google.Apis
 *      -Google.Apis.Sheets.v4
 *      -HtmlAgilityPack
 *      
 * That should have you covered, but if it doesn't, try to install these as well (the packages above should install these by default, but if they don't, these are the remaining packages I have):
 *      -CefSharp.Common
 *      -cef.redist.x86
 *      -cef.redist.x64
 *      -Google.Apis.Auth
 *      -Google.Apis.Core
 *      -Newstonsoft.Json
 *      
 * Now that the project is set-up, here is a simple description of what this project does, and why it uses these packages.
 * CefSharp allowed us to create an open-source Chrome browser. That means HTML5 content, JavaScript and PDFs are supported within the browser (For more details: https://cefsharp.github.io/).
 * We used this to make the browser. This class, MainForm, is where we created the browser frame. WinForms allows you to design your Form (the Java equivalent of a JFrame) using a WYSIWYG editor.
 * The WYSIWYG editor lets you use a GUI to build the form. It then takes your design and generates code for it (found in MainForm.Designer.cs). You likely will not have to touch this.
 * 
 * On the right side of your screen, look for something called 'Solution Explorer'. If it is not already pinned to your screen, look for the icon and pin in. Find MainForm.cs, and right click.
 * 
 * You should see two options: View Code and View Designer. If you're reading this, your already looking at the code, so look at the Designer. Click on elements, and look at the Properties panel.
 * The icon with a page and wrench allows you to change the physical appearance of an element. The lightning icon lets you decide what happens when the element is interacted with.
 * 
 * In this project, there are three Forms: The MainForm (Browser), the AdminLoginForm (appears if you click the button with three dots), and the AdminForm, which appears after you login from the LoginForm.
 * 
 * We decided to use Google Sheets as our database, so head to DBCommunicator for a description of that. To parse through the webpage for 'demo' words, we used the HtmlAgilityPack. Explained below.
 */

namespace ChromiumBrowser
{
    public partial class MainForm : Form
    {
        //private ArrayList blacklistedWords = new ArrayList();
        //public String[] whitelistedWords;
        ArrayList wordsToCensor = new ArrayList();
        public String wordsToCensorStr = "";
       
        private ChromiumWebBrowser chrome;
        private DBCommunicator dbc = new DBCommunicator();
        private String warningHTML = "<!DOCTYPE html> <html> <body> <h1>You have attempted to access a banned wesite.</h1> <p>Your attempt has been recorded. You have been warned.</p> </body> </html>";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Browser_Load(object sender, EventArgs e)
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
            //String test = "test|more";
            string cleanupCommand = "document.body.innerHTML = document.body.innerHTML.replace(/" + wordsToCensorStr + "/g, '***');";
            chrome.ExecuteScriptAsyncWhenPageLoaded(cleanupCommand);
        }

        public void printStr(String str)
        {
            richTextBox2.Text = str;
        }

        public void scanWebpage(String url)
        {
            richTextBox1.Text = "";
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load(url);

            // Reads the text on screen, more accurate
            String s = document.DocumentNode.InnerText;

            // Reads all of the html, less accurate
            //String s = document.Text;

            s = s.ToLower();
            string[] array = s.Split('d');
            ArrayList demoStrings = new ArrayList();


            //The whitelist
            dbc.ReadWordShtEntries();
            ArrayList whiteList = new ArrayList();

            for(int i = 1; i < dbc.wordArray.Count; i++)
            {
                whiteList.Add(dbc.wordArray[i].ToString().ToLower());
            }



            // Clears the whitelist
            //whiteList.Clear();

            // Adds the demo string to parsedList
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i].StartsWith("emo"))
                {
                    demoStrings.Add("d" + array[i]);
                }
            }


            // Trims the demo strings
            ArrayList parsedList = new ArrayList();
            foreach(string str in demoStrings)
            {
                // Parses through each string character by character
                char[] chars = str.ToCharArray();
                int breakPoint = str.Length;

                for(int i = 0; i < chars.Length; i++)
                {
                    // Finds where to trim the demo string
                    if(!Char.IsLetter(chars[i]))
                    {
                        breakPoint = i;
                        break;
                    }
                }

                // Adds the trimmed demo word into the ArrayList
                parsedList.Add(str.Substring(0, breakPoint));
            }


            // Removes the whitelisted words from parsedList

            Boolean addToBlackList;
            foreach(string str in parsedList)
            {
                // Assumes the word to be bad
                addToBlackList = true;

                // Compares the current string to every element in the whitelist
                foreach(var word in whiteList)
                {
                    // If they are equal i.e. the string is whitelisted, remember this
                    if(str.Equals(word.ToString()))
                    {
                        addToBlackList = false;
                    }
                }

                // Add string to blackListedWords if NOT whitelisted
                if(addToBlackList)
                {
                    wordsToCensor.Add(str);
                }
            }


            // Gathers all of the unique blacklisted words into one ArrayList
            ArrayList uniqueBlacklistedWords = new ArrayList();
            foreach(string str in wordsToCensor)
            {
                // Adds to the list if not in already
                if(!uniqueBlacklistedWords.Contains(str))
                {
                    uniqueBlacklistedWords.Add(str);
                }
            }

            ArrayList uniqueWords = new ArrayList();

            for(int j = 0; j < wordsToCensor.Count; j++)
            {
                if(!uniqueWords.Contains(wordsToCensor[j]))
                {
                    uniqueWords.Add(wordsToCensor[j]);
                }
            }

            wordsToCensor = uniqueWords;

            // Prints the number words
            int badWordCount = wordsToCensor.Count;
            string[] words = s.Split(' ');
            int totalWordCount = words.Length; // Will be used later!!!
            double badWordPercent = (double)((int)(((double)badWordCount / totalWordCount) * 10000)) / 100;

            richTextBox1.Text += "\n\nNumber of bad words: " + badWordCount;
            richTextBox1.Text += "\nTotal words: " + totalWordCount;
            richTextBox1.Text += "\nPercentage of bad words: " + badWordPercent + "%";


            // Prints one of each blacklisted words
            richTextBox1.Text += "\nUnique bad words:\n";
            foreach(string str in wordsToCensor)
            {
                richTextBox1.Text += str + "\n";
            }

            censorArrayToString();
        }

        private void censorArrayToString()
        {
            int l = 0;

            foreach(string str in wordsToCensor)
            {
                if(l == 0)
                {
                    wordsToCensorStr = str;
                }
                else
                {
                    wordsToCensorStr = wordsToCensorStr + "|" + str;
                }
                l++;
                richTextBox2.Text = wordsToCensorStr;
            }
        }

        private void Chrome_AddressedChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                dbc.ReadSiteShtEntries();
                
                
                scanWebpage(urlTextBox.Text);
                urlTextBox.Text = e.Address;
                //chrome.LoadHtml(warningHTML, urlTextBox.Text);
            }));     
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            String url = urlTextBox.Text;

            chrome.Load(url);

            //chrome.LoadHtml(warningHTML, url);


            /*if (dbc.siteArray.Contains(url)) {
                int index = dbc.siteArray.IndexOf(url);
                chrome.LoadHtml(warningHTML, url);
            } else {
                chrome.Load(url);
            }    */
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            if(chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(chrome.CanGoBack)
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

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Console.Write("Test");
            }
        }
    }
}