using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CMD_News
{
    public static class DataController
    {
        private static readonly HttpClient Get_Req = new HttpClient();

        public static async Task<string> Get_Feed(string rssFeed)
        {
            HttpResponseMessage response;
            string responseString;
            try
            {
                response = await Get_Req.GetAsync(rssFeed);
                responseString = await response.Content.ReadAsStringAsync();
            }
            catch(Exception err)
            {
                Console.WriteLine(responseString = err.Message);
            }

            return responseString;
        }

        // This function will be called in the "Main" portion of the program
        // to extract the title, date published, and link information for each 
        // news story. The function will return a list "NewsItem" objects for
        // the view to display.
        public static List<NewsItem> ParseXML(string rawXML)
        {
            List<NewsItem> storyList = new List<NewsItem>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(rawXML);
            // Not sure what to use 'channelNode' for yet..
            XmlNodeList channelNode = xmlDoc.GetElementsByTagName("channel");
            XmlNodeList newsItems = xmlDoc.GetElementsByTagName("item");
            foreach (XmlNode news in newsItems)
            {
                XmlNodeList titleNode = news.SelectNodes("title");
                Console.WriteLine(titleNode[0].InnerText);
                //string tempTitle = news.GetElementsByTagName();
            }
            return storyList;
        }
    }
}
