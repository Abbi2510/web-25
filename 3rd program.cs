using System;

namespace Alphabet_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;

            Console.Write("\n\n");
            Console.Write("Display the pattern like 'A' with an asterisk:\n");
            for (row = 0; row <= 6; row++)
            {
                for (column = 0; column <= 6; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}
