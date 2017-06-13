using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double result = 0.0;

            if (figure == "square")
            {
                double squareSide = double.Parse(Console.ReadLine());

                result = squareSide * squareSide;
            }
            else if (figure == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());

                result = firstSide * secondSide;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                result = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());

                result = triangleSide * triangleHeight / 2;
            }

            Console.WriteLine("{0:f3}", result);
        }
    }
}
