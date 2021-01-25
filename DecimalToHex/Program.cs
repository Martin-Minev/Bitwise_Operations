using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            while (number > 0)
            {
                int d = number % 16;
                result = GetHexDigit(d) + result;
                number = number / 16;
            }
            Console.WriteLine(result);
        }
        public static string GetHexDigit(int d)
        {
            if (d < 10)
            {
                return "" + d;
            }
            else if (d == 10)
            {
                return "A";
            }
            else if (d == 11)
            {
                return "B";
            }
            else if (d == 12)
            {
                return "C";
            }
            else if (d == 13)
            {
                return "D";
            }
            else if (d == 14)
            {
                return "E";
            }
            else if (d == 15)
            {
                return "F";
            }
            else
            {
                throw new Exception("Invalid digit");
            }
        }

    }
}
