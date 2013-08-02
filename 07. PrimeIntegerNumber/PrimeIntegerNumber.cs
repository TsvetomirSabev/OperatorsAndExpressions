// Write an expression that checks if given positive integer number n (n ≤ 100)
// is prime. E.g. 37 is prime.

using System;

class PrimeIntegerNumber
{
    static void Main()
    {
        Console.WriteLine("Enter one positive integer number until 100:");
        byte numInteger = byte.Parse(Console.ReadLine());

        if ((numInteger == 2 || numInteger == 3 || numInteger == 5 ||
            numInteger == 7) ^ (numInteger % 2 != 0 && numInteger % 3 != 0 &&
            numInteger % 5 != 0 && numInteger % 7 != 0))
        {

            Console.WriteLine("Prime number -> True!");
        }
        else
        {
            Console.WriteLine("Prime number -> False!");
        }
    }
}

