using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double weekends = double.Parse(Console.ReadLine());

        double totalWeekends = 48;
        double saturdayGamesInSofia = (totalWeekends - weekends) * 3 / 4;
        double sundayGamesInHome = weekends;
        double holidayGamesInSofia = holidays * 2 / 3;

        double totalGames = saturdayGamesInSofia + sundayGamesInHome + holidayGamesInSofia;

        if (yearType == "leap")
        {
            totalGames *= 1.15;
        }
        Console.WriteLine(Math.Floor(totalGames));
    }
}