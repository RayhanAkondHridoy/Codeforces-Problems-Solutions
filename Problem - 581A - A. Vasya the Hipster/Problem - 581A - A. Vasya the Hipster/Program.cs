using System;

namespace Problem___581A___A._Vasya_the_Hipster
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = input[0];
            int b = input[1];

            if ((a>=1 && a<=100) && (b>=1 && b<=100))
            {
                int day = 0;
                int pair = 0;
                if (a>b)
                {
                    day = b;
                    pair = (a - b) / 2;
                }
                else
                {
                    day = a;
                    pair = (b - a) / 2;
                }

                Console.WriteLine($"{day} {pair}");
            }
        }
    }
}