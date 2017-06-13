using System;

namespace P12._01.CurrencyConverter
{
    class CurrencyConverterV1
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
            double result = 0.0;

            if (firstCurrency == "BGN")
            {
                if (secondCurrency == "USD")
                {
                    result = money / usd;
                }
                else if (secondCurrency == "GBP")
                {
                    result = money / gbp;
                }
                else if (secondCurrency == "EUR")
                {
                    result = money / eur;
                }

            }

            else if (firstCurrency == "USD")
            {
                if (secondCurrency == "BGN")
                {
                    result = money * usd;
                }
                else if (secondCurrency == "GBP")
                {
                    result = money * usd / gbp;
                }
                else if (secondCurrency == "EUR")
                {
                    result = money * usd / eur;
                }
            }

            else if (firstCurrency == "GBP")
            {
                if (secondCurrency == "BGN")
                {
                    result = money * gbp;
                }
                else if (secondCurrency == "USD")
                {
                    result = money * gbp / usd;
                }
                else if (secondCurrency == "EUR")
                {
                    result = money * gbp / eur;
                }
            }

            else if (firstCurrency == "EUR")
            {
                if (secondCurrency == "BGN")
                {
                    result = money * eur;
                }
                else if (secondCurrency == "USD")
                {
                    result = money * eur / usd;
                }
                else if (secondCurrency == "GBP")
                {
                    result = money * eur / gbp;
                }

            }

            Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
        }
    }
}
