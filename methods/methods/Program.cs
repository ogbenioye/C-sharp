namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a name game to demonstrate how methods can be used
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = ReverseString(Console.ReadLine());

            Console.Write("What's your last name? ");
            string lastName = ReverseString(Console.ReadLine());

            Console.Write("In what city were you born? ");
            string placeOfBirth = ReverseString(Console.ReadLine());

            DisplayResult(firstName, lastName, placeOfBirth);
            DisplayResult(firstName + " " + lastName + " " + placeOfBirth);

            //Console.WriteLine(String.Format("{0} {1} {2}", firstName, lastName, placeOfBirth));
            //Console.ReadLine();
        }
        static string ReverseString(string data)
        {
            char[] charArray = data.ToCharArray();
            Array.Reverse(charArray);

            return String.Concat(charArray);
        }

        // explaining method overloading by changing method signatures. in this case the parameters
        static void DisplayResult(string firstName, string lastName, string city)
        {
            Console.Write("Results: ");
            Console.WriteLine(String.Format("{0} {1} {2}", firstName, lastName, city));
            //Console.ReadLine();
        }
        
        static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.WriteLine(message);
            //Console.ReadLine();
        }
    }
}