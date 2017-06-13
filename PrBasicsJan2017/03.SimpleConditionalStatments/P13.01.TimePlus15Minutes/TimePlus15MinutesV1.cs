using System;

namespace P13._01.TimePlus15Minutes
{
    class TimePlus15MinutesV1
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int munutesPlus15 = minutes + 15;

            if (munutesPlus15 >= 60)
            {
                hours = (hours + 1) % 24;
                munutesPlus15 -= 60;
            }
            //Console.WriteLine("{0}:{1:00}", hours, munutesPlus15);
            Console.WriteLine("{0}:{1}", hours, munutesPlus15.ToString("00"));
        }
    }
}
