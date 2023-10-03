namespace ObjectLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            /*{
                Make = "",
                Model = "",
                Year = 0,
                Colour = ""
            }*/
            ;

            /*myCar.Make = "Honda";
            myCar.Model = "CR-V";
            myCar.Year = 2022;
            myCar.Colour = "White";
            */
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Colour);

            //Demonstrating two instances of the Car object pointing to the same memory address
            Car myOtherCar;
            myOtherCar = myCar;

            myOtherCar.Year = 2019;

            //note myCar.Year in the line below will also have the value of 2019
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myCar.Year, myOtherCar.Colour);

            //calling the overloaded constructor
            Car newCar = new Car("Ford", "F150", 2015, "Blue");
            Console.WriteLine("{0} {1} {2} {3}", newCar.Make, newCar.Model, newCar.Year, newCar.Colour);

            //static method Demo
            Car.Meth();
            Console.ReadLine();
        }

        public static void Test() {
            Console.WriteLine("testing a theory");
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        //Constructor
        public Car()
        {
            Make = "Toyota";
        }

        //Constructor Overloading
        public Car(string make, string model, int year, string colour)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;

        }

        public static void Meth()
        {
            Console.WriteLine("classic example of a method from one class being called or reached from another class");
            Program.Test();
        }
    }

}