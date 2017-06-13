using System;

namespace P06._02.SumSeconds
{
    class SumSecondsV2
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());
            int thirdPlayer = int.Parse(Console.ReadLine());

            int totalSeconds = firstPlayer + secondPlayer + thirdPlayer;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}
