using System;

namespace OccuranceOfaBINARYdigitInDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            string result = string.Empty;
            while (number > 0)
            {
                int d = number % 2;
                result = d + result; // concatenate
                if (d==b)
                {
                    counter++;
                }
                number = number / 2;
            }
            Console.WriteLine(counter);
        }
    }
}
