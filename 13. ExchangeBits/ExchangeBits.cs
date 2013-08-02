// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 
// of given 32-bit unsigned integer.


using System;

class ExchangeBits
{
    static void Main()
    {
        Console.WriteLine("Enter one POSITIVE integer number:");
        int numUnsigned = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} -> {1}", numUnsigned,Convert.ToString
            (numUnsigned, 2).PadLeft(32, '0'));

        int mask = 1;
        mask = 1 << 3;
        int bit3 = (numUnsigned & mask) >> 3;
        
        mask = 1 << 24;
        int bit24 = (numUnsigned & mask) >> 24;

        mask = 1 << 4;
        int bit4 = (numUnsigned & mask) >> 4;

        mask = 1 << 25;
        int bit25 = (numUnsigned & mask) >> 25;

        mask = 1 << 5;
        int bit5 = (numUnsigned & mask) >> 5;

        mask = 1 << 26;
        int bit26 = (numUnsigned & mask) >> 26;


        if (bit3 == 0)
        {
            mask = ~(1 << 24);
            numUnsigned = numUnsigned  & mask;
        }
        else if (bit3 == 1)
        {
            mask = (1 << 24);
            numUnsigned = numUnsigned | mask;
        }

        if (bit24 == 0)
        {
            mask = ~(1 << 3);
            numUnsigned = numUnsigned & mask;
        }
        else if (bit24 == 1)
        {
            mask = (1 << 3);
            numUnsigned = numUnsigned | mask;
        }
                
        if (bit4 == 0)
        {
            mask = ~(1 << 25);
            numUnsigned = numUnsigned & mask;
        }
        else if (bit4 == 1)
        {
            mask = (1 << 25);
            numUnsigned = numUnsigned | mask;
        }

        if (bit25 == 0)
        {
            mask = ~(1 << 4);
            numUnsigned = numUnsigned & mask;
        }
        else if (bit25 == 1)
        {
            mask = (1 << 4);
            numUnsigned = numUnsigned | mask;
        }

        if (bit5 == 0)
        {
            mask = ~(1 << 26);
            numUnsigned = numUnsigned & mask;
        }
        else if (bit5 == 1)
        {
            mask = (1 << 26);
            numUnsigned = numUnsigned | mask;
        }

        if (bit26 == 0)
        {
            mask = ~(1 << 5);
            numUnsigned = numUnsigned & mask;
        }
        else if (bit26 == 1)
        {
            mask = (1 << 5);
            numUnsigned = numUnsigned | mask;
        }
                
        Console.WriteLine("{0} -> {1}", numUnsigned, 
            Convert.ToString(numUnsigned, 2).PadLeft(32, '0'));
    }
}

