// Write an expression that calculates trapezoid's area by given sides a and b 
// and height h.


using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Trapezoid's area.\nEnter side 'a', please:  ");
        double sideA = double.Parse(Console.ReadLine());

        Console.Write("Enter side 'b':\t\t ");
        double sideB = double.Parse(Console.ReadLine());

        Console.Write("Finally, enter a height: ");
        double height = double.Parse(Console.ReadLine());
        // Formula for calculate area of trapezoid: ((a + b) / 2) * h
        double trapArea = ((sideA + sideB) / 2) * height;

        Console.WriteLine("Trapezoid's area is:\t {0}", trapArea);
    }
}

