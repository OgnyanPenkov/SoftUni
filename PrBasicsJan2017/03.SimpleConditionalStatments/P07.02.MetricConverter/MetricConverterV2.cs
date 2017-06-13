using System;

namespace P07._02.MetricConverter
{
    class MetricConverterV2
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string fromMetric = Console.ReadLine().ToLower();
            string toMetric = Console.ReadLine().ToLower();

            double milimeters = 1000;
            double centimeters = 100;
            double meters = 1;
            double inches = 39.3700787;
            double feets = 3.2808399;
            double yards = 1.0936133;
            double kilometers = 0.001;
            double miles = 0.000621371192;

            double result = 0.0;

            switch (fromMetric)
            {
                case "mm":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / milimeters); break;
                        case "cm": result = value * (centimeters / milimeters); break;
                        case "in": result = value * (inches / milimeters); break;
                        case "ft": result = value * (feets / milimeters); break;
                        case "m": result = value * (meters / milimeters); break;
                        case "yd": result = value * (yards / milimeters); break;
                        case "km": result = value * (kilometers / milimeters); break;
                        case "mi": result = value * (miles / milimeters); break;
                    }
                    break;
                case "cm":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / centimeters); break;
                        case "cm": result = value * (centimeters / centimeters); break;
                        case "in": result = value * (inches / centimeters); break;
                        case "ft": result = value * (feets / centimeters); break;
                        case "m": result = value * (meters / centimeters); break;
                        case "yd": result = value * (yards / centimeters); break;
                        case "km": result = value * (kilometers / centimeters); break;
                        case "mi": result = value * (miles / centimeters); break;
                    }
                    break;
                case "in":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / inches); break;
                        case "cm": result = value * (centimeters / inches); break;
                        case "in": result = value * (inches / inches); break;
                        case "ft": result = value * (feets / inches); break;
                        case "m": result = value * (meters / inches); break;
                        case "yd": result = value * (yards / inches); break;
                        case "km": result = value * (kilometers / inches); break;
                        case "mi": result = value * (miles / inches); break;
                    }
                    break;
                case "ft":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / feets); break;
                        case "cm": result = value * (centimeters / feets); break;
                        case "in": result = value * (inches / feets); break;
                        case "ft": result = value * (feets / feets); break;
                        case "m": result = value * (meters / feets); break;
                        case "yd": result = value * (yards / feets); break;
                        case "km": result = value * (kilometers / feets); break;
                        case "mi": result = value * (miles / feets); break;
                    }
                    break;
                case "m":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / meters); break;
                        case "cm": result = value * (centimeters / meters); break;
                        case "in": result = value * (inches / meters); break;
                        case "ft": result = value * (feets / meters); break;
                        case "m": result = value * (meters / meters); break;
                        case "yd": result = value * (yards / meters); break;
                        case "km": result = value * (kilometers / meters); break;
                        case "mi": result = value * (miles / meters); break;
                    }
                    break;
                case "yd":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / yards); break;
                        case "cm": result = value * (centimeters / yards); break;
                        case "in": result = value * (inches / yards); break;
                        case "ft": result = value * (feets / yards); break;
                        case "m": result = value * (meters / yards); break;
                        case "yd": result = value * (yards / yards); break;
                        case "km": result = value * (kilometers / yards); break;
                        case "mi": result = value * (miles / yards); break;
                    }
                    break;
                case "km":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / kilometers); break;
                        case "cm": result = value * (centimeters / kilometers); break;
                        case "in": result = value * (inches / kilometers); break;
                        case "ft": result = value * (feets / kilometers); break;
                        case "m": result = value * (meters / kilometers); break;
                        case "yd": result = value * (yards / kilometers); break;
                        case "km": result = value * (kilometers / kilometers); break;
                        case "mi": result = value * (miles / kilometers); break;
                    }
                    break;
                case "mi":
                    switch (toMetric)
                    {
                        case "mm": result = value * (milimeters / miles); break;
                        case "cm": result = value * (centimeters / miles); break;
                        case "in": result = value * (inches / miles); break;
                        case "ft": result = value * (feets / miles); break;
                        case "m": result = value * (meters / miles); break;
                        case "yd": result = value * (yards / miles); break;
                        case "km": result = value * (kilometers / miles); break;
                        case "mi": result = value * (miles / miles); break;
                    }
                    break;
            }

            Console.WriteLine("{0} {1}", result, toMetric);
        }
    }
}
