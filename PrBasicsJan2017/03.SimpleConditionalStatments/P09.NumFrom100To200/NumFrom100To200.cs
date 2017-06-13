using System;

namespace P09.NumFrom100To200
{
    class NumFrom100To200
    {
        static void Main(string[] args)
        {
            nt num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (num > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else
            {
                Console.WriteLine("Between 100 and 200");
            }
        }
    }
}
