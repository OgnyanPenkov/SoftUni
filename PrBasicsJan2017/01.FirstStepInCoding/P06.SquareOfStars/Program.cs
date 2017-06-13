using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int squareSideSize = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', squareSideSize));
            for (int i = 0; i < squareSideSize - 2; i++)
            {
                Console.WriteLine("*" + new string(' ', squareSideSize - 2) + "*");
            }
            Console.WriteLine(new string('*', squareSideSize));
        }
    }
}
