using System;

namespace P14.EqualNumbers
{
    class EqualNumbers
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            bool isNumbersEquals = firstNumber == secondNumber && secondNumber == thirdNumber && firstNumber == thirdNumber;

            if (isNumbersEquals)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
