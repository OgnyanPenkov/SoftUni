using System;

class MaxNumber
{
    static void Main()
    {
        long numbersCount = long.Parse(Console.ReadLine());

        long max = long.MinValue;

        for (int i = 0; i < numbersCount; i++)
        {
            long currnetNumber = long.Parse(Console.ReadLine());

            if (currnetNumber > max)
            {
                max = currnetNumber;
            }
        }

        Console.WriteLine(max);
    }
}
