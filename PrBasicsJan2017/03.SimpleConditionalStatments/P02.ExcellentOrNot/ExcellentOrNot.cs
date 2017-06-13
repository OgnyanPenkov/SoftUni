using System;

namespace P02.ExcellentOrNot
{
    class ExcellentOrNot
    {
        static void Main(string[] args)
        {
            double result = double.Parse(Console.ReadLine());

            if (result >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent.");
            }
        }
    }
}
