using System;

class GrapeAndRakia
{
    static void Main()
    {
        double area = double.Parse(Console.ReadLine());
        double grapeKilos = double.Parse(Console.ReadLine());
        double brokenGrape = double.Parse(Console.ReadLine());

        double totalGrape = area * grapeKilos - brokenGrape;

        double grapeForRakia = totalGrape * 0.45;
        double rakia = grapeForRakia / 7.5;

        double salesRakia = rakia * 9.8;

        double grapeForSales = totalGrape * 0.55;

        double salesGrape = grapeForSales * 1.5;

        Console.WriteLine("{0:f2}", salesRakia);
        Console.WriteLine("{0:f2}", salesGrape);

    }
}