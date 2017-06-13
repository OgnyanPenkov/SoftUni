using System;

class LazyCatTom
{
    static void Main()
    {
        int dayOffs = int.Parse(Console.ReadLine());
        int dayWorks = 365 - dayOffs;

        int mins = dayOffs * 127 + dayWorks * 63;
        int diff = Math.Abs(mins - 30000);
        int hours = diff / 60;
        int minutes = diff % 60;

        if (mins > 30000)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
        }
        else
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
        }
    }
}