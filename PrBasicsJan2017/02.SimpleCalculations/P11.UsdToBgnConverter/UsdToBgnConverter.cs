using System;

namespace P11.UsdToBgnConverter
{
    class UsdToBgnConverter
    {
        static void Main(string[] args)
        {
            float firstCurrency = float.Parse(Console.ReadLine());

            float secondCurrency = firstCurrency * 1.79549f;
            Console.WriteLine("{0:f2}", secondCurrency);
        }
    }
}
