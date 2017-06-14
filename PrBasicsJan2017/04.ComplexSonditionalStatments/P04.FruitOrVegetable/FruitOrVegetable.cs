using System;

class FruitOrVegetable
{
    static void Main()
    {
        string inputString = Console.ReadLine().ToLower();

        bool fruit = inputString == "banana" || inputString == "apple" || inputString == "kiwi" || 
            inputString == "cherry" || inputString == "lemon" || inputString == "grapes";

        bool vegetable = inputString == "tomato" || inputString == "cucumber" || inputString == "pepper" || inputString == "carrot";

        if (fruit)
        {
            Console.WriteLine("fruit");
        }
        else if (vegetable)
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
