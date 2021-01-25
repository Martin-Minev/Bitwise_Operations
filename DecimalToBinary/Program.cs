using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;
            while (number>0)
            {
                int d = number % 2;
                result = d + result; // concatenate
                number = number / 2;
            }
            Console.WriteLine(result);
        }

    }
}
