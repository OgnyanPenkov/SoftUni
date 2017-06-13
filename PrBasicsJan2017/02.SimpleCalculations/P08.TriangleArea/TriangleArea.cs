using System;

namespace P08.TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var triangleSide = float.Parse(Console.ReadLine());
            var triangleHeight = float.Parse(Console.ReadLine());

            var triangleArea = triangleSide * triangleHeight / 2;

            //Console.WriteLine(Math.Round(area, 2)); //Be careful with Math.Round
            Console.WriteLine("{0:f2}", triangleArea);
        }
    }
}
