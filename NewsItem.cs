using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD_News
{
    // This is just used as a basic blueprint for all the news itmes pulled
    // in from a RSS feed.
    public class NewsItem
    {
        private string Title;
        private string Date;
        private string Link;

        public string title
        {
            set { this.Title = value; }
            get { return this.Title; }
        }

        public string date
        {
            set { this.Date = value; }
            get { return this.Date; }
        }
        public string link
        {
            set { this.Link = value; }
            get { return this.Link; }
        }

        public NewsItem(string t, string d, string l)
        {
            title = t;
            date = d;
            link = l;
        }
    }
}
