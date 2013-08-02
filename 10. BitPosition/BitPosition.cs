// Write a boolean expression that returns if the bit at position p (counting from
// 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.


using System;

class BitPosition
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number V:");
        int numberV = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a bit's position P:");
        int positionP = int.Parse(Console.ReadLine());

        int mask = 1;
        mask = 1 << positionP;
        int numVMask = numberV & mask;
        int bitValue = numVMask >> positionP;

        if (bitValue == 1)
        {
            Console.WriteLine("V = {0}; P = {1} -> false!", numberV, bitValue);
        }
        else if(bitValue == 0)
        {
            Console.WriteLine("V = {0}; P = {1} -> true!", numberV, bitValue);
        }
    } 
}

