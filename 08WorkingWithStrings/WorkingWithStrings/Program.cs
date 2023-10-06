using System.Text;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BACK-SLASH
            string text = "He said \"yes\" calmly";
            string text = "End of sentence here\nso new line here";
            string text = "cd into your c:\\ drive"; 
            /*or*/
            string text = @"cd into your c:\ drive";

            //STRING FORMAT
            string text = string.Format("{0} = {1}", "first", "second");
            string text = string.Format("{1} = {0}", "first", "second");
            string text = string.Format("{0} = {0}", "first", "second");

            string text = string.Format("{0:C}", 156.37); //currency formatting
            string text = string.Format("{0:N}", 1234567890); //number formatting
            string text = string.Format("{0:P}", .07); //percentage 
            string text = string.Format("Phone number: {0:### ### ### ####}", 2348137182043); //custom formatting

            string text = "  We concluded his was the best of all.";
            
            text = text.Substring(3, 26);
            text = text.ToUpper();
            text = text.Replace("S", "s");
            text = text.Remove(18, 4);

            StringBuilder myText = new StringBuilder();
            myText.Append(" BEGIN ");
            text = myText.ToString().Trim();

            Console.WriteLine(myText);
            Console.ReadLine();
        }
    }
}