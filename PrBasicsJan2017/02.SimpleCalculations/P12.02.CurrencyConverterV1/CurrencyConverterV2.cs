using System;

namespace P12._02.CurrencyConverterV2
{
    class CurrencyConverterV2
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            double bgn = 1.0;
            double usd = 1.79549;
            double gbp = 2.53405;
            double eur = 1.95583;
            double firstResult = 0.0;
            double result = 0.0;

            if (firstCurrency == "USD")
            {
                firstResult = money * usd;
            }
            else if (firstCurrency == "GBP")
            {
                firstResult = money * gbp;
            }
            else if (firstCurrency == "EUR")
            {
                firstResult = money * eur;
            }
            else if (firstCurrency == "BGN")
            {
                firstResult = money;
            }


            if (secondCurrency == "USD")
            {
                result = firstResult / usd;
            }
            else if (secondCurrency == "GBP")
            {
                result = firstResult / gbp;
            }
            else if (secondCurrency == "EUR")
            {
                result = firstResult / eur;
            }
            else if (secondCurrency == "BGN")
            {
                result = firstResult;
            }

            Console.WriteLine("{0:f2} {1}", result, secondCurrency);
        }
    }
}
