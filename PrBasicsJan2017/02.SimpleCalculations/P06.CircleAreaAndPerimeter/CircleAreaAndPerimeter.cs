using System;

namespace P06.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(circleRadius, 2);
            double circlePerimeter = 2 * Math.PI * circleRadius;

            Console.WriteLine(circleArea);
            Console.WriteLine(circlePerimeter);
        }
    }
}
