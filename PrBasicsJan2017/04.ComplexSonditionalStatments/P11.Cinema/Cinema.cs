using System;

class Cinema
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int seats = row * col;
        double price = -1;

        if (projectionType == "Premiere")
        {
            price = 12.00;
        }
        else if (projectionType == "Normal")
        {
            price = 7.50;
        }
        else
        {
            price = 5.00;
        }

        double result = seats * price;

        Console.WriteLine("{0:f2}", result);
    }
}
