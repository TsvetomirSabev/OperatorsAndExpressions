// Write an expression that checks if given point (x,y) is within a 
// circle K(O, 5).


using System;

class PointCircleCheck
{
    static void Main()
    {
        Console.Write("Circle's points (x,y).\nFor 'x' enter: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("For 'y' enter: ");
        double pointY = double.Parse(Console.ReadLine());

        int radius = 5;
                      // Formula for calculation: (x * x) + (y * y) < radius * radius
        bool result = (pointX * pointX) + (pointY * pointY) < radius * radius;

        Console.WriteLine("Points within the circle?\n{0}", result);
    }
}

