/*int[] numbers = new int[5];

numbers[0] = 1;
numbers[1] = 4;
numbers[2] = 3;
numbers[3] = 7;
numbers[4] = 10;

Console.WriteLine(numbers[1]);
Console.ReadLine();
*/

int[] numbers = new int[] { 1, 2, 3, 4 };
Console.WriteLine(numbers[1]);

Console.WriteLine(numbers.Length);
Console.ReadLine();

//iterating over an array with for loop
/*for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
Console.ReadLine();
*/

//with for each loop
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

string text = "Search solution explorer or add to source control which could also turn " +
    "to you selecting a repository to inspect git changes in the repos.";

char[] charArray = text.ToCharArray();
Array.Reverse(charArray);

//Console.WriteLine(charArray);

foreach (char textChar in charArray)
{
    Console.Write(textChar);
}
Console.ReadLine();

;