using System.Diagnostics.Metrics;

namespace whileIteration
{
    internal class Program
    {
        //Understanding while and do-while iterations
        static void Main(string[] args)
        {
            bool val = true;

            while (val)
            {
                val = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Print Numbers!");
            Console.WriteLine("2. Guessing Game");
            Console.WriteLine("3. Exit");

            string input = Console.ReadLine();

            if (input == "1" ) {
                PrintNumbers();
                Console.ReadLine();
                return true;
            } else if (input == "2"){
                GuessNumber();
                Console.ReadLine();
                return true;
            } else if (input == "3") {
                return false;
            } else {
                Console.WriteLine("Invalid input. Choose a correct option.");
                return true;
            }

        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Print Numbers game. Press Enter to coninue");
            Console.ReadLine();
           
            Console.Write("Enter any number: ");
            int input = int.Parse(Console.ReadLine());

            int counter = 1;
            while (counter <= input)
            {
                Console.Write(counter);
                if (counter < input) { Console.Write("-"); }
                counter++; 
            }
            Console.ReadLine();
        }

        private static void GuessNumber()
        {
            Console.Clear();

            Random number = new Random();
            int randNo = number.Next(1, 11);

            bool incorrect = true;
            int guesses = 0;

            do
            {
                Console.Write("guess a number from 1 to 10: ");
                string input = Console.ReadLine();

                if (input == randNo.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Incorrect");

                guesses++;
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guess(es)", guesses);
        }
    }
}