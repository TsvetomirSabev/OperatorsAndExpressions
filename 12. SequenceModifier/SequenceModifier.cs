/* We are given integer number n, value v (v=0 or 1) and a position p. Write a 
 * sequence of operators that modifies n to hold the value v at the position p 
 * from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/


using System;

class SequenceModifier
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number:");
        int numberN = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter 0 or 1:");
        byte valueBit = byte.Parse(Console.ReadLine());

        Console.WriteLine("Enter a position:");
        byte positionP = byte.Parse(Console.ReadLine());

        Console.WriteLine("number {0} binary is: {1}", 
            numberN, Convert.ToString(numberN, 2).PadLeft(32, '0'));
        if (valueBit == 0)
        {           
            int mask = 1;
            mask = ~(mask << positionP);
            int resultFor0 = numberN & mask;
            Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}", 
                numberN, positionP, valueBit, resultFor0);
            Console.WriteLine("result {0} binary is: {1}", 
                resultFor0, Convert.ToString(resultFor0, 2).PadLeft(32, '0'));
        }
        else if (valueBit == 1)
	    {
            int mask = 1;
            mask = mask << positionP;
            int resultFor1 = numberN | mask;
            Console.WriteLine("n = {0}, p = {1}, v = {2} -> {3}",
                numberN, positionP, valueBit, resultFor1);
            Console.WriteLine("result {0} binary is: {1}",
                resultFor1, Convert.ToString(resultFor1, 2).PadLeft(32, '0'));
	    }
    }
}

