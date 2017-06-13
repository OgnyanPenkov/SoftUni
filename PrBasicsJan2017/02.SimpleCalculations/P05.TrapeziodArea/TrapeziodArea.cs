using System;

namespace P05.TrapeziodArea
{
    class TrapeziodArea
    {
        static void Main(string[] args)
        {
            double firstBasis = double.Parse(Console.ReadLine());
            double secondBasis = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double trapezoidArea = (firstBasis + secondBasis) * height / 2;
            Console.WriteLine(trapezoidArea);
        }
    }
}
