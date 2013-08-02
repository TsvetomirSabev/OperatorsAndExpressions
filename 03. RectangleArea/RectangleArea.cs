// Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Rentagle area.\nEnter widht: ");
        double widht = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = widht * height;

        Console.WriteLine("Area is: {0}", area);


    }
}

