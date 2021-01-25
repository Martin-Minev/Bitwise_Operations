using System;

namespace Binarytodecimal
{
    class Program
    {
        static void Main(string[] args)
        {
           // string number = "1000111";
            string number = Console.ReadLine();
            long sum = 0;
            long magnitude = 1;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                sum += digit * magnitude;

                magnitude*=2;
            }
            Console.WriteLine(sum);
        }
    }
}
