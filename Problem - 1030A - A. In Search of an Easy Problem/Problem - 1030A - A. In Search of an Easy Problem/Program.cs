using System;

namespace Problem___1030A___A._In_Search_of_an_Easy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());

            if (n>=1 && n<=100)
            {
                int count = 0;

                int [] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                
                for (int i = 0; i < n; i++)
                {
                    if (input[i]==1)
                    {
                        count++;
                        break;
                    }
                }
                if (count!=0)
                {
                    Console.WriteLine("HARD");
                }
                else
                {
                    Console.WriteLine("EASY");
                }
            }
        }
    }
}
