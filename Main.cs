using CMD_News;
using System;
using System.Collections.Generic;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("|=========================================|");
Console.WriteLine("|--------------[ CMD NEWS! ]--------------|");
Console.WriteLine("|=========================================|");

List<string> RSS_List = DataController.GetSitesConfig();
string SelectedSource = UI.SourceSelect(RSS_List);
await UI.DisplayNewsItems(SelectedSource);