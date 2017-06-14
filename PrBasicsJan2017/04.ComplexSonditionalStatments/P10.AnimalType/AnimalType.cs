using System;

class AnimalType
{
    static void Main()
    {
        string animalType = Console.ReadLine();

        bool isReptile = animalType == "crocodile" || animalType == "tortoise" || animalType == "snake";

        if (animalType == "dog")
        {
            Console.WriteLine("mammal");
        }
        else if (isReptile)
        {
            Console.WriteLine("reptile");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}