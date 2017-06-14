using System;

class SmallShop
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        //string firstTown = "sofia";
        //string secondTown = "plovdiv";
        //string thirdTown = "varna";

        double price = 0.0;

        if (product == "coffee" && town == "sofia")
        {
            price = 0.5;
        }
        else if (product == "water" && town == "sofia")
        {
            price = 0.8;
        }
        else if (product == "beer" && town == "sofia")
        {
            price = 1.2;
        }
        else if (product == "sweets" && town == "sofia")
        {
            price = 1.45;
        }
        else if (product == "peanuts" && town == "sofia")
        {
            price = 1.6;
        }
        else if (product == "coffee" && town == "plovdiv")
        {
            price = 0.4;
        }
        else if (product == "water" && town == "plovdiv")
        {
            price = 0.7;
        }
        else if (product == "beer" && town == "plovdiv")
        {
            price = 1.15;
        }
        else if (product == "sweets" && town == "plovdiv")
        {
            price = 1.3;
        }
        else if (product == "peanuts" && town == "plovdiv")
        {
            price = 1.5;
        }
        else if (product == "coffee" && town == "varna")
        {
            price = 0.45;
        }
        else if (product == "water" && town == "varna")
        {
            price = 0.7;
        }
        else if (product == "beer" && town == "varna")
        {
            price = 1.1;
        }
        else if (product == "sweets" && town == "varna")
        {
            price = 1.35;
        }
        else if (product == "peanuts" && town == "varna")
        {
            price = 1.55;
        }
        else
        {
            Console.WriteLine("wrong data!");
        }

        Console.WriteLine(price * quantity);
    }
}
