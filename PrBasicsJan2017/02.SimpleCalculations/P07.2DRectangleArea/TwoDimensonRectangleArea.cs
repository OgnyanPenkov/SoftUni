using System;

namespace P07.TwoDimensonRectangleArea
{
    class TwoDimensonRectangleArea
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double firstSide = Math.Abs(x1 - x2);
            double secondSide = Math.Abs(y1 - y2);

            double squareArea = firstSide * secondSide;
            double squarePerimeter = 2 * (firstSide + secondSide);

            Console.WriteLine(squareArea);
            Console.WriteLine(squarePerimeter);
        }
    }
}
