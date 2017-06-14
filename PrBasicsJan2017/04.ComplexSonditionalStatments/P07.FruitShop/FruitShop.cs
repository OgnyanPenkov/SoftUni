using System;

class FruitShop
{
    static void Main()
    {
        string fruitType = Console.ReadLine().ToLower();
        string dayOfWeek = Console.ReadLine().ToLower();
        double fruitQuantity = double.Parse(Console.ReadLine());

        bool isWorkDays = dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || 
            dayOfWeek == "thursday" || dayOfWeek == "friday";

        bool isWeekendDays = dayOfWeek == "saturday" || dayOfWeek == "sunday";

        double price = -1;

        if (isWorkDays)
        {
            switch (fruitType)
            {
                case "banana": price = 2.5; break;
                case "apple": price = 1.2; break;
                case "orange": price = 0.85; break;
                case "grapefruit": price = 1.45; break;
                case "kiwi": price = 2.7; break;
                case "pineapple": price = 5.5; break;
                case "grapes": price = 3.85; break;
            }
        }
        else if (isWeekendDays)
        {
            switch (fruitType)
            {
                case "banana": price = 2.7; break;
                case "apple": price = 1.25; break;
                case "orange": price = 0.9; break;
                case "grapefruit": price = 1.6; break;
                case "kiwi": price = 3.0; break;
                case "pineapple": price = 5.6; break;
                case "grapes": price = 4.2; break;
            }
        }
        else
        {
            Console.WriteLine("wrong day!");
        }

        if (price >= 0)
        {
            Console.WriteLine("{0:f2}", (price * fruitQuantity));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}