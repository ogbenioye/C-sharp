using ScrapeLibrary;

namespace ScrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape scraper = new Scrape();
            string resp = scraper.ScrapeWebPage("https://msdn.microsoft.com");

            resp += "The END!!";

            Console.WriteLine(resp);
            Console.ReadLine();
        }
    }
}