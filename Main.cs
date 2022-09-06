using CMD_News;
using System;
using System.Collections.Generic;

string testRSS = "https://lifehacker.com/rss";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|=========================================|");
Console.WriteLine("|--------------[ CMD NEWS! ]--------------|");
Console.WriteLine("|=========================================|");
string justXML = await DataController.Get_Feed(testRSS);
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