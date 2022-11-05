using System;

namespace Problem___405A___A._Gravity_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            if (n>=1 && n<=100)
            {
                var x = Console.ReadLine();
                var xx = x.Split(' ');
                
                int[] input = new int[n];
                for (int i = 0; i < n; i++)
                {
                    input[i] = Convert.ToInt32(xx[i]);
                }

                bool f = true;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]>=1 && input[i]<=100)
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                        break;
                    }
                }
                
                if (f!=false)
                {
                    Array.Sort(input);
                    foreach (var v in input)
                    {
                        Console.Write(v+" ");
                    }
                }
            }
        }
    }
}
