using System;

class Bills
{
    static void Main()
    {
        int mounts = int.Parse(Console.ReadLine());

        double electricityTotal = 0;

        for (int i = 0; i < mounts; i++)
        {
            electricityTotal += double.Parse(Console.ReadLine());
        }

        int waterPrice = 20;
        int internetPrice = 15;

        double waterTotoal = mounts * waterPrice;
        double internetTotla = mounts * internetPrice;
        double others = (electricityTotal + waterTotoal + internetTotla) * 1.2;
        double average = (electricityTotal + waterTotoal + internetTotla + others) / mounts;

        Console.WriteLine("Electricity: {0:f2} lv", electricityTotal);
        Console.WriteLine("Water: {0:f2} lv", waterTotoal);
        Console.WriteLine("Internet: {0:f2} lv", internetTotla);
        Console.WriteLine("Other: {0:f2} lv", others);
        Console.WriteLine("Average: {0:f2} lv", average);
    }
}