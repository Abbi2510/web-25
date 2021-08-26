using System;
using System.Linq;

namespace Assin_3_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "python exercises";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("After converting the first character of each word of the said string:\n" + test(str1));
            str1 = "The quick brown Fox jumps over the little lazy Dog";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("After converting the first character of each word of the said string:\n" + test(str1));
        }
        public static string test(string str1)
        {
            return string.Join(" ", str1.Split(' ').Select(str1 => char.ToUpper(str1[0]) + str1.Substring(1)));
        }
    }
}
