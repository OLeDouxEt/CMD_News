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
    }

    public static string ParseXML(string rawXML)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(rawXML);
        XmlNodeList parentNode = xmlDoc.GetElementsByTagName("channel");
        foreach (XmlNode node in parentNode)
        {
            Console.WriteLine(node.InnerXml);
        }
    }
}
