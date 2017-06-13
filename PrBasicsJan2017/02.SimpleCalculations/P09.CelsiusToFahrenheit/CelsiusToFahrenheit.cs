using System;

namespace P09.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine(fahrenheit);
        }
    }
}
