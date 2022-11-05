using System;

namespace Problem___1304A___Two_Rabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                long[] input = Array.ConvertAll(Console.ReadLine().Split(' '), long.Parse);
                long x = input[0];
                long y = input[1];
                long a = input[2];
                long b = input[3];
                if ((y - x) % (a + b) == 0)
                    Console.WriteLine((y - x) / (a + b));
                else
                    Console.WriteLine("-1");
            }
        }
    }
}