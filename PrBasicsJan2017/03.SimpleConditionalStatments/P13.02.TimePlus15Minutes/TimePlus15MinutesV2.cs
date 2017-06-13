using System;

namespace P13._02.TimePlus15Minutes
{
    class TimePlus15MinutesV2
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes;
            int minutesPlus15 = totalMinutes + 15;

            int outputHours = (minutesPlus15 / 60) % 24;
            int outputMinutes = minutesPlus15 % 60;

            Console.WriteLine("{0}:{1:00}", outputHours, outputMinutes);
        }
    }
}
