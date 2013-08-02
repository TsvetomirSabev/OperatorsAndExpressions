// Write an expression that checks for given point (x, y) if it is within the
// circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, 
// height=2).

using System;

class PointsXYPositions
{
    static void Main()
    {
        Console.WriteLine("Enter point X:");
        float pointX = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter point Y:");
        float pointY = float.Parse(Console.ReadLine());

        byte centerK1 = 1;
        byte centerK2 = 1;
        byte radius = 3;

        byte topX = 1;
        sbyte leftY = -1;
        byte width = 6;
        byte height = 2;

        bool circle = ((pointX - 1) * (pointX - 1) +
            (pointY - 1) * (pointY - 1)) <= 3 * 3;
        bool rectangle = ((-1 <= pointX) && (pointX <= 5)) &&
            ((-1 <= pointY) && (pointY <= 1));

        if (circle == true)
        {
            Console.WriteLine("Within the circle!");
        }
        else if (circle == false)
        {
            Console.WriteLine("Out of the circle!");
        }
        if (rectangle == true)
        {
            Console.WriteLine("Whitin the rectangle!");
        }
        else if (rectangle == false)
        {
            Console.WriteLine("Out of the rectangle!");
        }

    }
}


