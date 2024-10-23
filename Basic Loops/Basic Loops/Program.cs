// See https://aka.ms/new-console-template for more information




using System.Runtime.ConstrainedExecution;

bool playAgain = true;

do

{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userAnswer = Console.ReadLine();
    if (userAnswer.ToLower() != "y")
    {
        playAgain = false;
        Console.WriteLine("Goodbye!");
    }

} while (playAgain);


bool stopProgram = false;

while (stopProgram == false)
{

    Console.WriteLine("Enter a number");
    int usersNumber = int.Parse(Console.ReadLine());

    for (int i = usersNumber; i >= 0; i--)
    {
        Console.Write($" {i} ");
    }
    Console.WriteLine();

    for (int i = 0; i <= usersNumber; i++)
    {
        Console.Write($" {i} ");
    }
    Console.WriteLine();

    Console.WriteLine("Would you like to continue (y/n) ?");
    string usersAnswer = Console.ReadLine();
    if (usersAnswer.ToLower() != "y")
    {
        stopProgram = true;
    }
}
Console.WriteLine("Goodbye!");




int keypadEntry = 13579;
bool doorOpen = false;
int maxInputs = 5;
int inputs = 0;

Console.WriteLine("Enter the 5 digit key code");


    while (doorOpen == false && inputs < maxInputs)
    {
        int userCode = int.Parse(Console.ReadLine());
    inputs++;

        if (userCode == keypadEntry)
        {
            doorOpen = true;
        Console.WriteLine("Welcome! The door is open.");
        }
        else
    {
        if (inputs < maxInputs)
        {
            Console.WriteLine("Incorrect code. Please try again.");
        }
        
    }

}

if (doorOpen == false && inputs == maxInputs)
{
    Console.WriteLine("Too many attempts. Try again later");
}

