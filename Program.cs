// Kyle Solesbee 10/2/23
// Number Analyzer Lab

int number = 0;
bool oddEven;
string name;
string exit = "no";

while (exit == "no")
{
    Console.WriteLine("Please enter your name: ");
    name = Console.ReadLine();
    Console.WriteLine($"{name}, please enter an integer between 1 and 100 ");
    while (!int.TryParse(Console.ReadLine(), out number) ||
                        (number <= 0 ||
                         number > 100))
    {
        Console.WriteLine($"{name}, invalid input, try again.");
    }

    oddEven = number % 2 == 0;

    if (!oddEven && number < 60)
    {
        Console.WriteLine($"{name}, {number} is odd and less than 60");
    }
    else if (oddEven && number < 25 && number > 1)
    {
        Console.WriteLine($"{name}, the number even and less than 25");
    }
    else if (oddEven && number > 25 && number < 61)
    {
        Console.WriteLine($"{name}, the number is even and between 26 and 60 inclusive");
    }
    else if (oddEven && number > 60)
    {
        Console.WriteLine($"{name}, {number} is even and greater than 60");
    }
    else if (!oddEven && number > 60)
    {
        Console.WriteLine($"{name}, {number} is odd and greater than 60");
    }

    Console.WriteLine($"{name}, would you like to exit? Yes/No");
    exit = Console.ReadLine().ToLower();
}
