using System;

namespace P05.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            int rectangleFirstSide = int.Parse(Console.ReadLine());
            int rectangleSecondSide = int.Parse(Console.ReadLine());

            int rectangleArea = rectangleFirstSide * rectangleSecondSide;

            Console.WriteLine(rectangleArea);
        }
    }
}
