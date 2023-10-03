using System.Net;

namespace MyCodeLibrary
{
    public class Scrape
    {
        public string ScrapeWebPage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebPage(string url, string filePath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filePath, reply);

            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}