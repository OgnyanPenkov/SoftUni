using System;

namespace P10.EqualWords
{
    class EqualWords
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine().ToLower();
            string secondString = Console.ReadLine().ToLower();

            if (firstString == secondString)
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
