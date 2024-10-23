// See https://aka.ms/new-console-template for more information
bool continueProgram = true;

while (continueProgram)
{
    Console.WriteLine("Enter a number: ");
    int userNumber = int.Parse(Console.ReadLine());

    int sum = 0;

    for (int i = 1; i <= userNumber; i++)
    {
        sum += i;
    }
    Console.WriteLine($"{sum}");

    Console.WriteLine("Would you like to continue (y/n)?");
    string userAnswer = Console.ReadLine().ToLower();
    if (userAnswer != "y")
    {
        continueProgram = false;
        Console.WriteLine("Goodbuy!");
    }
}
