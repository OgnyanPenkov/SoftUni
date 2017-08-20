using System;

class MinNumber
{
    static void Main()
    {
        long numbersCount = long.Parse(Console.ReadLine());

        long min = long.MaxValue;

        for (int i = 0; i < numbersCount; i++)
        {
            long currentNumber = long.Parse(Console.ReadLine());

            if (currentNumber < min)
            {
                min = currentNumber;
            }
        }

        Console.WriteLine(min);
    }
}
