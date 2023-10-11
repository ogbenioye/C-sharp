namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string content = File.ReadAllText(@"c:\users\pelumi\documents\me\resumes\coverletter.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("We have a problem");
                Console.WriteLine("Make sure you have written the file name correctly");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Looks like we have a problem");
                Console.WriteLine("Make sure you have typed the correct directory paths!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occurred!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Code finalizing
                //Setting objects to null
                //Closing database connections
                Console.WriteLine("Closing the program..");
            }
            Console.ReadLine();

        }
    }
}