using System;

class SmallShopV2
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string town = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());

        //string sofiaCity = "sofia";
        //string plovdivCity = "plovdiv";
        //string varnaCity = "varna";

        double coffeeInSofiaPrice = 0.5;
        double waterInSofiaPrice = 0.8;
        double beerInSofiaPrice = 1.2;
        double sweetsInSofiaPrice = 1.45;
        double peanutsInSofiaPrice = 1.6;

        double coffeeInPlovdivPrice = 0.4;
        double waterInPlovdivPrice = 0.7;
        double beerInPlovdivPrice = 1.15;
        double sweetsInPlovdivPrice = 1.3;
        double peanutsInPlovdivPrice = 1.5;

        double coffeeInVarnaPrice = 0.45;
        double waterInVarnaPrice = 0.7;
        double beerInVarnaPrice = 1.10;
        double sweetsInVarnaPrice = 1.35;
        double peanutsInVarnaPrice = 1.55;

        double price = 0;

        if (town == "sofia")
        {
            if (product == "coffee")
            {
                price = coffeeInSofiaPrice;
            }
            else if (product == "water")
            {
                price = waterInSofiaPrice;
            }
            else if (product == "beer")
            {
                price = beerInSofiaPrice;
            }
            else if (product == "sweets")
            {
                price = sweetsInSofiaPrice;
            }
            else if (product == "peanuts")
            {
                price = peanutsInSofiaPrice;
            }
        }
        else if (town == "plovdiv")
        {

            if (product == "coffee")
            {
                price = coffeeInPlovdivPrice;
            }
            else if (product == "water")
            {
                price = waterInPlovdivPrice;
            }
            else if (product == "beer")
            {
                price = beerInPlovdivPrice;
            }
            else if (product == "sweets")
            {
                price = sweetsInPlovdivPrice;
            }
            else if (product == "peanuts")
            {
                price = peanutsInPlovdivPrice;
            }
        }
        else if (town == "varna")
        {
            if (product == "coffee")
            {
                price = coffeeInVarnaPrice;
            }
            else if (product == "water")
            {
                price = waterInVarnaPrice;
            }
            else if (product == "beer")
            {
                price = beerInVarnaPrice;
            }
            else if (product == "sweets")
            {
                price = sweetsInVarnaPrice;
            }
            else if (product == "peanuts")
            {
                price = peanutsInVarnaPrice;
            }
        }

        Console.WriteLine(price * quantity);
    }
}
