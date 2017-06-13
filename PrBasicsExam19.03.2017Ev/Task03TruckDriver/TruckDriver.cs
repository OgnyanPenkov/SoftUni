using System;

class TruckDriver
{
    static void Main()
    {
        string season = Console.ReadLine();
        double kilometerForMont = double.Parse(Console.ReadLine());

        double salary = 0;

        if (season == "Spring" || season == "Autumn")
        {
            if (kilometerForMont <= 5000)
            {
                salary += kilometerForMont * 4 * 0.75;
            }
            else if (kilometerForMont <= 10000)
            {
                salary += kilometerForMont * 4 * 0.95;
            }
            else
            {
                salary += kilometerForMont * 4 * 1.45;
            }
        }
        else if (season == "Summer")
        {
            if (kilometerForMont <= 5000)
            {
                salary += kilometerForMont * 4 * 0.9;
            }
            else if (kilometerForMont <= 10000)
            {
                salary += kilometerForMont * 4 * 1.1;
            }
            else
            {
                salary += kilometerForMont * 4 * 1.45;
            }

        }
        else if (season == "Winter")
        {
            if (kilometerForMont <= 5000)
            {
                salary += kilometerForMont * 4 * 1.05;
            }
            else if (kilometerForMont <= 10000)
            {
                salary += kilometerForMont * 4 * 1.25;
            }
            else
            {
                salary += kilometerForMont * 4 * 1.45;
            }

        }

        double salryAfterTaxes = salary *= 0.9;

        Console.WriteLine("{0:f2}", salryAfterTaxes);

    }
}