// Write an expression that extracts from a given integer i the value of a 
// given bit number b. Example: i=5; b=2 -> value=1.
 

using System;

class BitValue
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number:");
        int iNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a bit number(position):");
        byte bitPositionB = byte.Parse(Console.ReadLine());

        int mask = 1;
        mask = mask << bitPositionB;
        int compare = mask & iNumber;
        int finalResult = compare >> bitPositionB;

        if (finalResult == 1)
        {
            Console.WriteLine("number(i) = {0}; bit position(b) = {1} -> value(0;1) = {2}.",
                iNumber, bitPositionB, finalResult );
        }
        else 
        {
            Console.WriteLine("number(i) = {0}; bit position(b) = {1} -> value(0;1) = {2}.",
            iNumber, bitPositionB, finalResult);
        }
    }
}

