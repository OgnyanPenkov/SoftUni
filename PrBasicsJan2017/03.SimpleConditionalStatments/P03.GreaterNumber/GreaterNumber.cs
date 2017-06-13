using System;

namespace P03.GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int firstNubmer = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            bool isFurstNumberGreater = firstNubmer > secondNumber;
            if (isFurstNumberGreater)
            {
                Console.WriteLine(firstNubmer);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }
        }
    }
}
