using System;

namespace Problem___1223A___A._CME
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 4)
                    Console.WriteLine((4 - n));
                else if (n % 2 == 0)
                    Console.WriteLine(0);
                else
                    Console.WriteLine(1);
            }
        }
    }
}
