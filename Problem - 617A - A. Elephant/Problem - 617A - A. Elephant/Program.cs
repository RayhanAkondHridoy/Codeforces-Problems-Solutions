using System;

namespace Problem___617A___A._Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            var steps = 0;
            var move = Convert.ToInt32(Console.ReadLine());
            if (move<=1000000)
            {
                while (move>0)
                {
                    ++steps;
                    move -= 5;
                }
                Console.WriteLine(steps);
            }
        }
    }
}