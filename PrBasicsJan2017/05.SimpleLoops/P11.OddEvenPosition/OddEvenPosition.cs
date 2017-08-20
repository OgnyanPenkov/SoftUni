using System;

class OddEvenPosition
{
    static void Main(string[] args)
    {
        double number = double.Parse(Console.ReadLine());

        double oddSum = 0;
        double evenSum = 0;

        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;

        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;

        for (int i = 0; i < number; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());


            if (i % 2 == 0)
            {
                oddSum += currentNumber;

                if (currentNumber > oddMax)
                {
                    oddMax = currentNumber;
                }

                if (currentNumber < oddMin)
                {
                    oddMin = currentNumber;
                }
            }
            else
            {
                evenSum += currentNumber;

                if (currentNumber > evenMax)
                {
                    evenMax = currentNumber;
                }

                if (currentNumber < evenMin)
                {
                    evenMin = currentNumber;
                }
            }
        }

        Console.WriteLine("OddSum = {0}", oddSum);

        if (oddMin == double.MaxValue)
        {
            Console.WriteLine("OddMin = No");
        }
        else
        {
            Console.WriteLine("OddMin = {0}", oddMin);
        }

        if (oddMax == double.MinValue)
        {
            Console.WriteLine("OddMax = No");
        }
        else
        {
            Console.WriteLine("OddMax = {0}", oddMax);
        }


        Console.WriteLine("EvenSum = {0}", evenSum);

        if (evenMin == double.MaxValue)
        {
            Console.WriteLine("EvenMin = No");
        }
        else
        {
            Console.WriteLine("EvenMin = {0}", evenMin);
        }

        if (evenMax == double.MinValue)
        {
            Console.WriteLine("Evenmax = No");
        }
        else
        {
            Console.WriteLine("EvenMax = {0}", evenMax);
        }
    }
}
