using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Input count of integers: ");
        int numbersCount = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            Console.Write("Input next integer:");
            int currentInteger = int.Parse(Console.ReadLine());

            sum += currentInteger;
        }

        Console.WriteLine(sum);
    }
}

