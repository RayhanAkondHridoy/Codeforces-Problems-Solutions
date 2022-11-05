using System;

namespace Problem___513A___A._Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n1 = input[0];
            int n2 = input[1];
            int k1 = input[2];
            int k2 = input[3];
            
            Console.WriteLine(n1 > n2 ? "First" : "Second");
        }
    }
}
