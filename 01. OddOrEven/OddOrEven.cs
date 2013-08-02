// Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even integer.");
        }
        else
        {
            Console.WriteLine("Odd integer.");
        }
    }
}

