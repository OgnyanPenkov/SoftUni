using System;

class SmallShopV3
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        // prices in sofia town
        double coffeeInSofiaPrice = 0.5;
        double waterInSofiaPrice = 0.8;
        double beerInSofiaPrice = 1.2;
        double sweetsInSofiaPrice = 1.45;
        double peanutsInSofiaPrice = 1.6;

        //prices in plovdiv town
        double coffeeInPlovdivPrice = 0.4;
        double waterInPlovdivPrice = 0.7;
        double beerInPlovdivPrice = 1.15;
        double sweetsInPlovdivPrice = 1.3;
        double peanutsInPlovdivPrice = 1.5;
        
        //prices in varna town
        double coffeeInVarnaPrice = 0.45;
        double waterInVarnaPrice = 0.7;
        double beerInVarnaPrice = 1.10;
        double sweetsInVarnaPrice = 1.35;
        double peanutsInVarnaPrice = 1.55;

        double price = 0;

        if (town == "sofia")
        {
            switch (product)
            {
                case "coffee":  price = coffeeInSofiaPrice; break;
                case "water": price = waterInSofiaPrice; break;
                case "beer": price = beerInSofiaPrice; break;
                case "sweets": price = sweetsInSofiaPrice; break;
                case "peanuts": price = peanutsInSofiaPrice; break;
            }
        }
        else if (town == "plovdiv")
        {
            switch (product)
            {
                case "coffee": price = coffeeInPlovdivPrice; break;
                case "water": price = waterInPlovdivPrice; break;
                case "beer": price = beerInPlovdivPrice; break;
                case "sweets": price = sweetsInPlovdivPrice; break;
                case "peanuts": price = peanutsInPlovdivPrice; break;
            }

        }
        else if (town == "varna")
        {
            switch (product)
            {
                case "coffee": price = coffeeInVarnaPrice; break;
                case "water": price = waterInVarnaPrice; break;
                case "beer": price = beerInVarnaPrice; break;
                case "sweets": price = sweetsInVarnaPrice; break;
                case "peanuts": price = peanutsInVarnaPrice; break;
            }
        }
        else
        {
            Console.WriteLine("wrong data");
        }

        Console.WriteLine(price * quantity);
    }
}
