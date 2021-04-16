using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChromiumBrowser
{
    class DBCommunicator
    {
        public static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        public static readonly string ApplicationName = "DemoCensor";

        public static readonly string SpreadsheetId = "1xvWfsJny2RsKmDB-deTfon-sb22hnJdnHnxh2LRi080";

        public static readonly string userSht = "Users";

        public static readonly string siteSht = "Sites";


        public static SheetsService service;

        public ArrayList siteArray = new ArrayList();
        
        public ArrayList userArray = new ArrayList();

        public DBCommunicator()
        {
            this.EstablishDBConnection();
        }

        public void EstablishDBConnection()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        /**
         * Dr. Gurary--
         * 
         * Here is the problem. I want to be able to store the contents of the each line into a String, 
         * then place that string into an array. I am able to to print the contents of the google sheet to the Output.  
         * I need to be able to write the contents of this sheet to the RichTextAreas in the AdminForm.
         */

        public void ReadSiteShtEntries()
        {

            siteArray.Clear();

            var range = $"{siteSht}!A1:B500"; //Chooses the range of cells to take from the Google Sheet
            var request = service.Spreadsheets.Values.Get(SpreadsheetId, range); //Retreiving range

            var response = request.Execute();
            var values = response.Values;

            int i = 0;

            
           
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    siteArray.Add(new Site (row[0].ToString(), row[1].ToString()));
                    i++;

                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }

        }

        public void ReadUserShtEntries()
        {
            userArray.Clear();

            var range = $"{userSht}!A1:C500";
            var request = service.Spreadsheets.Values.Get(SpreadsheetId, range); //Retreiving range

            var response = request.Execute();
            var values = response.Values;

            int i = 0;



            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    userArray.Add(row[0].ToString() + " --- " + row[1].ToString() + " --- " + row[2].ToString());
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

    }

    class Site
    {
        public string Url { get; }
        public string Status { get; }

        public Site(string Url, string Status )
        {
            this.Url = Url;
            this.Status = Status;
        }

        public override string ToString()
        {
            return Url + " - " + Status;
        }

    }
}
