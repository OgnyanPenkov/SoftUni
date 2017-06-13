using System;

class SmartLily
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int priceToy = int.Parse(Console.ReadLine());

        double money = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                money = money + i * 5;
                money = money - 1;
            }
            else
            {
                money = money + priceToy;
            }
        }

        if (money >= price)
        {
            Console.WriteLine("Yes! {0:f2}", money - price);
        }
        else
        {
            Console.WriteLine("No! {0:f2}", price - money);
        }

    }
}
