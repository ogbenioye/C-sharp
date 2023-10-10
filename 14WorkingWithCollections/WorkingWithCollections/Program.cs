using System.Collections;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                VIN = "A1",
                Make = "Toyota",
                Model = "Highlander"
            };

            Car car2 = new Car() {
                VIN = "B1",
                Make = "Benz",
                Model = "AMG"
            };

            Book b1 = new Book();
            b1.Author = "Olu Pelu";
            b1.Title = "Get rich in 24 hours";
            b1.ISBN = "000-000-000";

            //ArrayList (old list style)
            /*
            ArrayList list = new ArrayList();
            list.Add(car1);
            list.Add(car2);
            list.Add(b1);

            list.Remove(b1);

            foreach (Car car in list)
            {
                Console.WriteLine(car.Make);
            }
            */

            //List<T>  (generic list)
            /*
            List<Car> cars = new List<Car>();
            cars.Add(car1);
            cars.Add(car2);
            
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
            */

            //Dictionary<Tkey, Tvalue>
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add(car1.VIN, car1);
            cars.Add(car2.VIN, car2);
            //Console.WriteLine(cars["B1"].Model);

            //COLLECTION INITIALIZERS

            //List
            List<Book> Library = new List<Book>()
            {
                new Book() {Author="Ben Carson", Title="Gifted Hands", ISBN="0-000-00-0"},
                new Book() {Author="Rick Warren", Title="Purpose Driven Life", ISBN="0-00-000"},
            };
            
            foreach (Book book in Library)
            {
               Console.WriteLine(book.Title + " by " + book.Author);
            }
            /*
            List<string> names = new List<string>()
            {
                "ayo",
                "bola",
                "tinuke"
            };
            */

            //Dictionary
            /*
            Dictionary<int, string> positions = new Dictionary<int, string>()
            {
                {1, names[0]},
                {2, names[2]},
                {3, names[1]}
            };
            */

            Console.ReadLine();
        }
    }

    class Car {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
    }
}