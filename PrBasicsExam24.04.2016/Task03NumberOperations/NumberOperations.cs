using System;

class NumberOperations
{
    static void Main()
    {
        double firstNumber = int.Parse(Console.ReadLine());
        double secondtNumber = int.Parse(Console.ReadLine());
        string operation = Console.ReadLine();

        double result;

        switch (operation)
        {
            case "+":
                result = firstNumber + secondtNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} + {1} = {2} - even", firstNumber, secondtNumber, result);
                }
                else
                {
                    Console.WriteLine("{0} + {1} = {2} - odd", firstNumber, secondtNumber, result);
                }
                break;
            case "-":
                result = firstNumber - secondtNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} - {1} = {2} - even", firstNumber, secondtNumber, result);
                }
                else
                {
                    Console.WriteLine("{0} - {1} = {2} - odd", firstNumber, secondtNumber, result);
                }
                break;
            case "*":
                result = firstNumber * secondtNumber;
                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} * {1} = {2} - even", firstNumber, secondtNumber, result);
                }
                else
                {
                    Console.WriteLine("{0} * {1} = {2} - odd", firstNumber, secondtNumber, result);
                }
                break;
            case "/":
                if (secondtNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }
                else
                {
                    result = firstNumber / secondtNumber;
                    Console.WriteLine("{0} / {1} = {2:f2}", firstNumber, secondtNumber, result);
                }
                break;
            case "%":
                if (secondtNumber == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstNumber);
                }
                else
                {
                    result = firstNumber % secondtNumber;
                    Console.WriteLine("{0} % {1} = {2}", firstNumber, secondtNumber, result);
                }
                break;
        }

    }
}

