# CMD_News
A simple command line based news feed reader.

13/9/22
- UI improvements and RSS feed file
Added a UI class to handle most of the work displaying the interface selection and the news stories. Also added a config file for users to enter their desired RSS feeds for the application to read from.

5/9/22
- Simple title, date, and link output
In this early stage, the application only displays the title, publication date, and story link to the console for a single RSS feed. This will later be updated to support multiple feeds will a simple, command line interface.

- Added "NewsItem" class and parsing method
Continued developing the news reader. The main improvement were the addition of the "ParseXML" method in the "DataController" class and the "NewsItem" class used to parse the XML information and set the info to objects.
