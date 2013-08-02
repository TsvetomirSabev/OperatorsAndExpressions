// Write a boolean expression that checks for given integer if it can be divided
// (without remainder) by 7 and 5 in the same time.

using System;

class DivideWithoutRemainder
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number:");
        int number = int.Parse(Console.ReadLine());

        bool checker = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("Divides by 7 and 5 in the same time?\n{0}", checker);
    }
}

