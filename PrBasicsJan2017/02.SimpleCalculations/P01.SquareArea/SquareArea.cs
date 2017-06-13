using System;

namespace P01.SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            int squareSide = int.Parse(Console.ReadLine());
            int squareArea = squareSide * squareSide;

            Console.WriteLine(squareArea);
        }
    }
}
