using System;

namespace Problem___34B___B._Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int n = input1[0];
            int m = input1[1];
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(input2);
            
            for(int i = 0; i < n; i++)
            {
                if (input2[i] < 0)
                {
                    sum += Math.Abs(input2[i]);
                    count++;
                    if (count >= m)
                        break;
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}
