using System;

class TriangleOf55Stars
{
    static void Main()
    {
        for (int row = 0; row <= 10; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}