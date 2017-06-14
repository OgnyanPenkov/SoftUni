using System;

class InvalidNumberV2
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isNumberInvalid = (number < 100 || number > 200) && number != 0;

        if (isNumberInvalid)
        {
            Console.WriteLine("invalid");
        }
    }
}