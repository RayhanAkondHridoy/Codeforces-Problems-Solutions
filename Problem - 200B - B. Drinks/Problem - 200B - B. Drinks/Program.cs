using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem___200B___B._Drinks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n>=1 && n<=100)
            {
                double[] arrayX = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);

                bool f = true;

                if (arrayX.Length==n)
                {
                    foreach (var v in arrayX)
                    {
                        if (v>=0 && v<=100)
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
                        double output = (double) arrayX.Sum() / n;
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}