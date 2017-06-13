using System;

namespace P15.Number0to100Text
{
    class Number0to100Text
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string output = "";
            
       
            if (number < 0 || number > 100)
            {
                Console.WriteLine("Invalid number");
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if (number >= 10 && number < 20)
            {
                switch (number)
                {
                    case 10: output = "ten"; break;
                    case 11: output = "eleven"; break;
                    case 12: output = "twelve"; break;
                    case 13: output = "thirteen"; break;
                    case 14: output = "fourteen"; break;
                    case 15: output = "fifteen"; break;
                    case 16: output = "sixteen"; break;
                    case 17: output = "seventeen"; break;
                    case 18: output = "eihteen"; break;
                    case 19: output = "nineteen"; break;
                }
                Console.WriteLine(output);
            }
            else
            {
                int tens = number / 10;
                int units = number % 10;

                switch (tens)
                {
                    case 2: output += "twenty "; break;
                    case 3: output += "thirty "; break;
                    case 4: output += "forty "; break;
                    case 5: output += "fifty "; break;
                    case 6: output += "sixty "; break;
                    case 7: output += "seventy "; break;
                    case 8: output += "eighty "; break;
                    case 9: output += "ninety "; break;

                }
                switch (units)
                {
                    case 1: output += "one"; break;
                    case 2: output += "two"; break;
                    case 3: output += "three"; break;
                    case 4: output += "four"; break;
                    case 5: output += "five"; break;
                    case 6: output += "six"; break;
                    case 7: output += "seven"; break;
                    case 8: output += "eight"; break;
                    case 9: output += "nine"; break;
                }

                Console.WriteLine(output.Trim());
            }
        }
    }
}
