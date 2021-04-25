using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ChromiumBrowser
{
    internal class DBCommunicator
    {
        /**
         * This class communicates with the Google Sheet where Users, Sites, and Words are held. Every time we communicate with the database, they are held in globally accessible ArrayLists.
         */
        public static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        // Name of the sheets document
        public static readonly string ApplicationName = "DemoCensor";

        // Don't touch this-- In the off chance something gets messed up, this
        // ID number can be found by looking at the link of the Google sheet. (https://docs.google.com/spreadsheets/d/1xvWfsJny2RsKmDB-deTfon-sb22hnJdnHnxh2LRi080/edit#gid=2019175546)
        public static readonly string SpreadsheetId = "1xvWfsJny2RsKmDB-deTfon-sb22hnJdnHnxh2LRi080";

        // If you look at the Google Sheet, each indivdual sheet has a name.
        // These readonly strings hold the names of the sheet so the API can
        // reference the correct sheet
        public static readonly string userSht = "Users";

        public static readonly string siteSht = "Sites";

        public static readonly string wordSht = "Words";

        // Calling the Sheets API
        public static SheetsService service;

        public ArrayList siteArray = new ArrayList(); // This holds the websites which can have a statues of Banned/Blacklisted/Allowed

        public ArrayList userArray = new ArrayList(); // This holds the users that have hit bad websites.

        public ArrayList wordArray = new ArrayList(); // This holds the list of whitelisted 'demo' words

        public DBCommunicator()
        {
            this.EstablishDBConnection();
        }

        public void EstablishDBConnection()
        {
            GoogleCredential credential;
            using(var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public void ReadSiteShtEntries()
        {
            siteArray.Clear();

            var range = $"{siteSht}!A1:B500"; //Chooses the range of cells to take from the Google Sheet
            var request = service.Spreadsheets.Values.Get(SpreadsheetId, range); //Retreiving range

            var response = request.Execute();
            var values = response.Values;

            //int i = 0;

            if(values != null && values.Count > 0)
            {
                foreach(var row in values)
                {
                    siteArray.Add(new Site(row[0].ToString(), row[1].ToString()));
                    //i++;
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

            if(values != null && values.Count > 0)
            {
                foreach(var row in values)
                {
                    userArray.Add(new User(row[0].ToString(), row[1].ToString(), row[2].ToString()));
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        public void ReadWordShtEntries()
        {
            wordArray.Clear();

            var range = $"{wordSht}!A1:A500";
            var request = service.Spreadsheets.Values.Get(SpreadsheetId, range); //Retreiving range

            var response = request.Execute();
            var values = response.Values;

            int i = 0;

            if(values != null && values.Count > 0)
            {
                foreach(var row in values)
                {
                    wordArray.Add(new UncensoredWord(row[0].ToString()));
                    i++;
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        public void CreateWebsiteEntry(String url, String status)
        {
            var range = $"{siteSht}!A1:B500"; // If your list of websites gets larger than 500, you're going to need to update this
            var valueRange = new ValueRange();

            var objectList = new List<object>() { url, status };
            valueRange.Values = new List<IList<object>> { objectList };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }

        public void CreateUserEntry(int id, String IPAddress, String url)
        {
            var range = $"{userSht}!A1:C500"; // If your list of Users gets larger than 500, you're going to need to update this
            var valueRange = new ValueRange();

            var objectList = new List<object>() { id, IPAddress, url };
            valueRange.Values = new List<IList<object>> { objectList };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }

        public void CreateWordEntry(String url, String status)
        {
            var range = $"{wordSht}!A1:A500"; // If your list of whitelisted words gets larger than 500, you're going to need to update this
            var valueRange = new ValueRange();

            var objectList = new List<object>() { url, status };
            valueRange.Values = new List<IList<object>> { objectList };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
        }
    }

    internal class Site
    {
        public string Url
        {
            get;
        }

        public string Status
        {
            get;
        }

        public Site(string Url, string Status)
        {
            this.Url = Url;
            this.Status = Status;
        }

        public override string ToString()
        {
            return Url + " - " + Status;
        }
    }

    internal class User
    {
        public string UserID
        {
            get;
        }

        public string IPAddress
        {
            get;
        }

        public string UrlVisited
        {
            get;
        }

        public User(string ip, string id, string url)
        {
            this.UserID = id;
            this.IPAddress = ip;
            this.UrlVisited = url;
        }

        public override string ToString()
        {
            return UserID + " - " + IPAddress + " - " + UrlVisited;
        }
    }

    internal class UncensoredWord
    {
        public string Word
        {
            get;
        }

        public UncensoredWord(string Word)
        {
            this.Word = Word;
        }

        public override string ToString()
        {
            return Word;
        }
    }
}