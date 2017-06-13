using System;

namespace P12._03.CurrencyConverterV3
{
    class CurrencyConverterV3
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            double usd = 1.79549;
            double gbp = 2.53405;
            double eur = 1.95583;
            double result = 0.0;

            switch (firstCurrency)
            {
                case "BGN":
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
                    break;

                case "USD":
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
                    break;

                case "GBP":
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
                    break;

                case "EUR":
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
                    break;
            }
            Console.WriteLine("{0:f2} {1}", result, secondCurrency);
        }
    }
}
