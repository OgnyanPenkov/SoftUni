using System;

class LeftАndRightSum
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int leftSum = 0;
        int rightSum = 0;

        for (int i = 0; i < 2 * number; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (i < number)
            {
                leftSum += currentNumber;
            }
            else
            {
                rightSum += currentNumber;
            }
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum ={0}", leftSum);
        }
        else
        {
            int diff = Math.Abs(leftSum - rightSum);
            Console.WriteLine("No, diff = {0}", diff);
        }
    }
}