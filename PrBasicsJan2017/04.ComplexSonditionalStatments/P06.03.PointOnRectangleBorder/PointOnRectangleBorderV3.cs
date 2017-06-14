using System;

class PointOnRectangleBorderV3
{
    static void Main(string[] args)
    {
        //Rectnagle coordinates
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        //Point coordinates
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool xOnBorder = ((x == x1 || x == x2) && y >= y1 && y <= y2);
        bool yOnBorder = ((y == y1 || y == y2) && x >= x1 && x <= x2);

        if (xOnBorder || yOnBorder)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }

}
