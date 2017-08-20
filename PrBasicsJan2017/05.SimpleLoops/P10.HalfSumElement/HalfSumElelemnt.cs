using System;

class HalfSumElement
{
    static void Main()
    {
        int nubersCount = int.Parse(Console.ReadLine());

        int max = int.MinValue;
        int sum = 0;

        for (int i = 0; i < nubersCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            sum += currentNumber;

            if (currentNumber > max)
            {
                max = currentNumber;
            }
        }

        sum = sum - max;

        if (sum == max)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", max);
        }
        else
        {
            int diff = Math.Abs(sum - max);
            Console.WriteLine("No");
            Console.WriteLine("Diff = {0}", diff);
        }
    }
}
