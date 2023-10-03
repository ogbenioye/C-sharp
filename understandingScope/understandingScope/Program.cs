using System.Reflection.Metadata.Ecma335;

namespace understandingScope
{
    internal class Program
    {
       //only accessible in this class. Even if made public, the scope and accessibilty remains same.
        static string s = "";
        static void Main(string[] args)
        {
            s = "sample";
            Console.WriteLine(s);

            Function();
            Console.ReadLine();
        }

        //only accessible in this class even with the "public" keyword.
        public static string d = "yes";


        //only accessible in this class even if made public.
        static void Function()
        {
            Console.WriteLine("extra method, " + d + ", " + s);
            Sample.x = "2";
        }
    }

    class Sample
    {        // accessible accross all classes
        public static string x = "12";

        //accessible accross all classes
        public static void main()
        {
            // only accessible in this method "main"
            static int minus(int x, int y)
            {
                empty();
                return x - y;
            }
        }

        //only accessible in this class
        static void empty()
        {
            Console.WriteLine("empty method");
        }

    }
}