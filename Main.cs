using CMD_News;
using System.Xml;

string testRSS = "https://lifehacker.com/rss";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("|-----[ CMD NEWS! ]-----|");
Console.WriteLine("|_______________________|");
string test = await DataController.Get_Feed(testRSS);
//Console.WriteLine(test);
