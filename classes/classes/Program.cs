namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Prado";
            myCar.Year = 2005;
            myCar.Colour = "Pink";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);
            Console.ReadLine();

            decimal val = myCar.DetermineMarketPrice(myCar);
            Console.WriteLine("{0:C}", val);
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public decimal DetermineMarketPrice(Car car)
        {
            if (Year >= 2010)
                return 20000;
            else
                return 5000;
        }

        public decimal Price { get; set; }
    }
}