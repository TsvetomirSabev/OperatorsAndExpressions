// Write a boolean expression for finding if the bit 3 (counting from 0) of a
// given integer is 1 or 0.


using System;

class ThirdBitPosition
{
    static void Main()
    {
        Console.Write("Enter one integer number, please: ");
        int inputNum = int.Parse(Console.ReadLine());

        int position = 3;
        int mask = 1;
        mask = 1 << position;
        int maskNum = inputNum & mask;
        int finalResult = maskNum >> position;

        Console.WriteLine("Bit 3 of this integer number is: {0}", finalResult);
        
    }
}

