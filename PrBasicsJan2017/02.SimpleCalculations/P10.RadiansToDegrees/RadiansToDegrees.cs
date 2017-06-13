using System;

namespace P10.RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degree = Math.Round(radian * 180 / Math.PI);

            Console.WriteLine(degree);
        }
    }
}
