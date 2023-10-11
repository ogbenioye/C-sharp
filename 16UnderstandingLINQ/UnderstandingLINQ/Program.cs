namespace UnderstandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car {VIN = "A1", Make = "Lexus", Model = "RX450", StickerPrice = 50000, Year = 2018},
                new Car {VIN = "B2", Make = "Toyota", Model = "Land Cruiser", StickerPrice = 75000, Year = 2020},
                new Car {VIN = "C3", Make = "BMW", Model = "55i", StickerPrice = 80000, Year = 2007},
                new Car {VIN = "D4", Make = "Lexus", Model = "ES300", StickerPrice = 55000, Year = 2019},
                new Car {VIN = "E5", Make = "Toyota", Model = "Rav4", StickerPrice = 25000, Year = 2013},
                new Car {VIN = "F6", Make = "Benz", Model = "AMG", StickerPrice = 65000, Year = 2022},
            };

            //LINQ query
            
            var lexus = from car in cars
                        where car.Make == "Toyota"
                        && car.Year > 2015
                        select car;
            
            /*
            var myCars = from car in cars
                         orderby car.Year descending
                         select car;
            */

            //Selcting some of the properties of a class instaead of the whole class.
            //I dont see how this would be useful though.
            var partCar = from car in cars
                          where car.Make == "BMW" && car.Make == "Benz"
                          select new {car.Make, car.Model};


            //LINQ method
            //var lexus = cars.Where(c => c.Make == "Toyota" && c.Year > 2015);

            var myCars = cars.OrderByDescending(c => c.Make).First(c => c.Make == "Lexus");

            var firstLexus = cars.OrderByDescending(c => c.Make).First(c => c.Make == "Lexus");
            //Console.WriteLine(firstLexus.VIN);

            //Console.WriteLine(cars.TrueForAll(c => c.Year > 2010));

            cars.ForEach(car => Console.WriteLine(car.StickerPrice - 3000));

            if (cars.Exists(c => c.Make == "Benz"))
            {
                Console.WriteLine("We have exactly " + cars.Count(c => c.Make == "Benz") + " Benz car(s) available.");
            };

            //Console.WriteLine(cars.Sum(car => car.StickerPrice));

            /*
            foreach (var car in lexus)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int StickerPrice { get; set; }
        public int Year { get; set; }
    }
}