// Write an expression that checks for given integer if its third digit 
// (right-to-left) is 7. E. g. 1732  true.


using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.WriteLine("Enter one integer number, please: ");
        int numRandom = int.Parse(Console.ReadLine());

        int numThirdDigit = (numRandom / 100) % 10;

        if (numThirdDigit == 7)
        {
            Console.WriteLine("True!\nThird digit (rigth-to-left) is 7!");
        }
        else 
        {
            Console.WriteLine("False!\nThird digit (rigth-to-left) is {0}!", numThirdDigit);
        }
    }
}

