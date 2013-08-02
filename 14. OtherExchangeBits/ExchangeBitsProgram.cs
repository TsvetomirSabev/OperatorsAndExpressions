// * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits
// {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


using System;

class ExchangeBitsProgram
{
    static void Main()
    {
        Console.Write("Enter one POSITIVE integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} -> {1}", number, Convert.ToString(number, 2).
                PadLeft(32, '0'));

        Console.Write("Enter start bit position: ");
        int startBit = int.Parse(Console.ReadLine());

        Console.Write("Enter end bit position: ");
        int endBit = int.Parse(Console.ReadLine());

        Console.Write("Bits to exchange: ");
        int changeK = int.Parse(Console.ReadLine());
        changeK = changeK + 1;

        for (int i = startBit, j = endBit; i < startBit + changeK - 1; i++, j++)
        {
            int firstMask = 1 << i;
            int secondMask = 1 << j;
            int bit1 = (number & firstMask);
            int bit2 = (number & secondMask);

            if (bit1 == 0)
            {
                int container = 1 << j;
                number = (number & (~container));
            }
            else
            {
                int container = 1 << j;
                number = (number | container);
            }
            if (bit2 == 0)
            {
                int container = 1 << i;
                number = (number & (~container));
            }
            else
            {
                int container = 1 << i;
                number = (number | container);
            }
        }
        Console.WriteLine("{0} -> {1}", number, Convert.ToString(number, 2).
            PadLeft(32, '0'));
    }
}

