using System;

namespace P02.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            Console.Write("inches = ");

            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;

            Console.WriteLine("centimeters = {0}", centimeters);

            // Console.Write("centimeters = ");
            // Console.WriteLine(centimeters);
        }
    }
}
