using System;

namespace Assin_3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; /* Declares a string of size 100 */
            int l = 0;

            Console.Write("\n\nThe length of a string :\n");
            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}\n\n", l);
        }
    }
}
