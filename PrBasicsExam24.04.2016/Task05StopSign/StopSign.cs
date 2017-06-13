using System;

class StopSign
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.Write(new string('.', n + 1));
        Console.Write(new string('_', 2 * n + 1));
        Console.WriteLine(new string('.', n + 1));


        //Upeer part without first row
        int dotsCount = n;
        int linesCount = n * 2 - 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dotsCount));
            Console.Write("//");
            Console.Write(new string('_', linesCount));
            Console.Write("\\\\");
            Console.WriteLine(new string('.', dotsCount));

            dotsCount -= 1;
            linesCount += 2;
        }

        //Middle row
        Console.Write("//");
        Console.Write(new string('_', 2 * n - 3));
        Console.Write("STOP!");
        Console.Write(new string('_', 2 * n - 3));
        Console.WriteLine("\\\\");

        //Down part without Middle row
        dotsCount = 0;
        linesCount = n * 4 - 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dotsCount));
            Console.Write("\\\\");
            Console.Write(new string('_', linesCount));
            Console.Write("//");
            Console.WriteLine(new string('.', dotsCount));

            dotsCount += 1;
            linesCount -= 2;
        }

    }
}
