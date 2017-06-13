using System;

class Styrofoam
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double houseArea = double.Parse(Console.ReadLine());
        int windows = int.Parse(Console.ReadLine());
        double styrofoamInPackage = double.Parse(Console.ReadLine());
        double styrofoamPrice = double.Parse(Console.ReadLine());

        double area = houseArea - windows * 2.4;
        area *= 1.1;

        double syrofoamNeeded = Math.Ceiling(area / styrofoamInPackage) * styrofoamPrice;

        if (budget >= syrofoamNeeded)
        {
            Console.WriteLine("Spent: {0:f2}", syrofoamNeeded);
            Console.WriteLine("Left: {0:f2}", budget - syrofoamNeeded);
        }
        else
        {
            Console.WriteLine("Need more: {0:f2}", syrofoamNeeded - budget);
        }
    }
}