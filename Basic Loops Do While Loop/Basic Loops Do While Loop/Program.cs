// See https://aka.ms/new-console-template for more information


int keypadEntry = 13579;
bool doorOpen = false;
int maxInputs = 5;
int inputs = 0;


Console.WriteLine("Enter the 5 digit key code");

do

{
    int userCode = int.Parse(Console.ReadLine());

    if (userCode == keypadEntry)
    {
        doorOpen = true;
        Console.WriteLine("Welcome! The door is open.");
        break;
    }
    else
    {
        inputs++;

        if (inputs < maxInputs)
        {
            Console.WriteLine("Incorrect code. Please try again.");
        }
    }
}while (doorOpen == false && inputs < maxInputs);

if (doorOpen == false && inputs == maxInputs)
{ 
    Console.WriteLine("Too many attempts. Try again later");
}



