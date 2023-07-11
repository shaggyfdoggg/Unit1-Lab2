using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();
bool loop = true;

do
{

Console.WriteLine($"{name}, please enter a number from 1 - 100. Press 0 to leave");
int number = int.Parse(Console.ReadLine());

    if (number % 2 == 1 && number < 60)
    {
        Console.WriteLine($"{name}, your number is odd and less than 60.");
    }
    else if (number % 2 == 0 && number > 2 && number <= 24)
    {
        Console.WriteLine($"{name}, your number is even and less than 25");
    }
    else if (number % 2 == 0 && number > 26 && number <= 60)
    {
        Console.WriteLine($"{name}, your number is even and between 26 and 60 inclusive");
    }
    else if (number % 2 == 0 && number > 60)
    {
        Console.WriteLine($"{name}, your number is even and greater than 60");
    }
    else if (number % 2 == 1 && number > 60)
    {
        Console.WriteLine($"{name}, your number is odd and greater than 60");
    }
    else if (number == 0)
    {
        Console.WriteLine("Goodbye!");
        loop = false;
    }
    else
    {
        Console.WriteLine($"{name}, please try again");
    }
} while (loop != false);