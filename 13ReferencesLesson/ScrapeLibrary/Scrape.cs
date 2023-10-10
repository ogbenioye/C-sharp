using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {

        public string ScrapeWebPage(string url)
        {
            return GetPage(url);
        }

        public string ScrapeWebPage(string url, string filePath)
        {
            string reply = GetPage(url);
            File.WriteAllText(filePath, reply);

            return reply;
        }

        private string GetPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

    }
}