using System;

namespace P06._01.SumSeconds
{
    class SumSecondsV1
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int totalSeconds = firstPlayer + secondPlayer + thirdPlayer;
            int minutes = 0;
            int seconds = 0;

            if (totalSeconds >= 120)
            {
                minutes = 2;
            }
            else if (totalSeconds >= 60)
            {
                minutes = 1;
            }

            if (minutes == 2)
            {
                seconds = totalSeconds - 120;
            }
            else if (minutes == 1)
            {
                seconds = totalSeconds - 60;
            }
            else
            {
                seconds = totalSeconds;
            }

            if (seconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, seconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, seconds);
            }
        }
    }
}
