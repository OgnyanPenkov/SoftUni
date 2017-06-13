using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            double speedInfo = double.Parse(Console.ReadLine());

            if (speedInfo <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speedInfo > 10 && speedInfo <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speedInfo > 50 && speedInfo <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speedInfo > 150 && speedInfo <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
