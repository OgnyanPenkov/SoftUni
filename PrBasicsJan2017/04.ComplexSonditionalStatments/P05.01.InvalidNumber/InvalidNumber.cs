using System;

class InvalidNumber
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        bool isNumberValid = number >= 100 && number <= 200 || number == 0;

        if (!(isNumberValid))
        {
            Console.WriteLine("invalid");
        }
    }
}