using System;
using System.Linq;


namespace Assin_3_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "c# Exercises";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the said string:\n" + test(str1));
            str1 = "C# is used to develop web apps, desktop apps, mobile apps, games and much more.";
            Console.WriteLine("\nOriginal string: " + str1);
            Console.WriteLine("\nAfter alternating the case of each letter of the said string:\n" + test(str1));
        }
        public static string test(string str)
        {
            string text = str.Replace(" ", "  ");
            string result_str = "";
            result_str += Char.ToUpper(str[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (i % 2 == 0) result_str += Char.ToUpper(text[i]);
                else if (i % 2 != 0 && Char.IsUpper(text[i])) result_str += Char.ToLower(text[i]);
                else result_str += text[i];
            }
            result_str = result_str.Replace("  ", " ");
            return result_str;

        }
    }
}
