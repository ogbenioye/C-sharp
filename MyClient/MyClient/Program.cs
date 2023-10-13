using MyCodeLibrary;

namespace MyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Scrape myScrape = new Scrape();
           string value = myScrape.ScrapeWebPage("https://msdn.microsoft.com");

            Console.WriteLine(value);
            Console.ReadLine(); 
        }
    }
}