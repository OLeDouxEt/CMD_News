using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_News
{
    public static class UI
    {
        public static string SourceSelect(List<string> rssList)
        {
            string returnable = "";
            int selectInt = 0;
            for (int i = 0; i < rssList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {rssList[i]}");
            }
            Console.WriteLine("Select News Source: ");
            string selection = Console.ReadLine();
            try
            {
                selectInt = Int32.Parse(selection);
                if (selectInt > 0 && selectInt <= rssList.Count)
                {
                    returnable = rssList[selectInt - 1];
                    return returnable;
                }
                else
                {
                    Console.WriteLine("Selection is not on the list. Try again.");
                    return SourceSelect(rssList);
                }
            }
            catch
            {
                Console.WriteLine("Not a number. Select again");
                return SourceSelect(rssList);
            }
        }

        public static async Task DisplayNewsItems(string rssFeed)
        {
            string justXML = await DataController.Get_Feed(rssFeed);
            List<NewsItem> newsParse = DataController.ParseXML(justXML);
            foreach (NewsItem item in newsParse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item.title);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item.date);
                Console.WriteLine(item.link);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
