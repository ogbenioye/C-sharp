//Decisions

Console.WriteLine("Create Password");
Console.Write("Enter a strong password: ");
string userPass = Console.ReadLine();

Console.WriteLine("Password created");

Console.Write("Enter Password to login: ");
string userInput = Console.ReadLine();

/*
if (userInput != userPass)
{
    Console.WriteLine("Incorrect Password");
} else if (userInput ==  userPass)
{
    Console.WriteLine("You are logged-in");
}
*/

// another method to if-else statements
string message = (userInput == userPass) ? "You are logged in" : "Incorrect Password";

Console.WriteLine(message);
Console.ReadLine();


//Formatting String Literal
string name = "John";
Console.WriteLine("You are logged in as {0}", name);
Console.ReadLine();

string userID = "A3FDG71";
Console.WriteLine("You are logged in as {0} with user id {1}", name, userID);
Console.ReadLine();