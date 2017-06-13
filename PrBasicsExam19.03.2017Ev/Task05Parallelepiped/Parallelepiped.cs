using System;

class Parallelepiped
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.WriteLine("+" + new string('~', n - 2) + "+" + new string('.', 2 * n + 1));

        //Upper part
        for (int i = 0; i < 2 * n + 1; i++)
        {
            Console.WriteLine("|" + new string('.', i) + "\\" + new string('~', n - 2) + "\\" + new string('.', 2 * n - i));
        }

        //Down part
        for (int i = 0; i < 2 * n + 1; i++)
        {
            Console.WriteLine(new string('.', i) + "\\" + new string('.', 2 * n - i) + "|" + new string('~', n - 2) + "|");
        }

        //Last row
        Console.WriteLine(new string('.', 2 * n + 1) + "+" + new string('~', n - 2) + "+");
    }
}