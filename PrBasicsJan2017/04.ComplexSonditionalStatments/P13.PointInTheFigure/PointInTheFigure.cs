using System;

class PointInTheFigure
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool isInside = (x > 0 && x < height * 3 && y > 0 && y < height) || 
            (x > height && x < height * 2 && y > 0 && y < height * 4);

        bool isOutside = (x < 0 || x > height * 3 || y < 0 || y > height) && 
            (x < height || x > height * 2 || y < 0 || y > height * 4) || 
            (x < height && y > height) || (x > height * 2 && y > height);

        if (isInside)
        {
            Console.WriteLine("inside");
        }
        else if (isOutside)
        {
            Console.WriteLine("outside");
        }
        else
        {
            Console.WriteLine("border");
        }
    }
}

