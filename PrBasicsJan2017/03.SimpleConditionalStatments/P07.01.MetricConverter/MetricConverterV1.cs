using System;

namespace P07._01.MetricConverter
{
    class MetricConverterV1
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string fromUnits = Console.ReadLine();
            var toUnits = Console.ReadLine();


            if (fromUnits == "mm")
            {
                value = value / 1000;
            }
            else if (fromUnits == "cm")
            {
                value = value / 100;
            }
            else if (fromUnits == "mi")
            {
                value = value / 0.000621371192;
            }
            else if (fromUnits == "in")
            {
                value = value / 39.3700787;
            }
            else if (fromUnits == "km")
            {
                value = value / 0.001;
            }
            else if (fromUnits == "ft")
            {
                value = value / 3.2808399;
            }
            else if (fromUnits == "yd")
            {
                value = value / 1.0936133;
            }
            if (toUnits == "mm")
            {
                value = value * 1000;
            }
            else if (toUnits == "cm")
            {
                value = value * 100;
            }
            else if (toUnits == "mi")
            {
                value = value * 0.000621371192;
            }
            else if (toUnits == "in")
            {
                value = value * 39.3700787;
            }
            else if (toUnits == "km")
            {
                value = value * 0.001;
            }
            else if (toUnits == "ft")
            {
                value = value * 3.2808399;
            }
            else if (toUnits == "yd")
            {
                value = value * 1.0936133;
            }
            Console.WriteLine("{0} {1}", value, toUnits);
        }
    }
}
