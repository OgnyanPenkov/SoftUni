using System;

class RepairTiles
{
    static void Main()
    {
        double garden = double.Parse(Console.ReadLine());
        double plateX = double.Parse(Console.ReadLine());
        double plateY = double.Parse(Console.ReadLine());
        double benchX = double.Parse(Console.ReadLine());
        double benchY = double.Parse(Console.ReadLine());

        double gardenArea = garden * garden;
        double benchArea = benchX * benchY;
        double plateArea = plateX * plateY;
        double full = gardenArea - benchArea;
        double plateNeeded = full / plateArea;
        double timeNeeded = plateNeeded / 5; //(0.2)

        Console.WriteLine(plateNeeded);
        Console.WriteLine(timeNeeded);
    }
}