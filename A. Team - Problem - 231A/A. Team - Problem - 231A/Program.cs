using System;
using System.Linq;

namespace A._Team___Problem___231A
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------//
            ////    Annotation:    A. Team (Problem - 231A - Codeforces)    ////
            //---------------------------------------------------------------//



            var n = Convert.ToInt32(Console.ReadLine());
            if (n>=1 && n<=1000)
            {
                int temp = 0;
                for (int i = 0; i < n; i++)
                {
                    bool f = true;
                    int[] arrayX = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    for (int j = 0; j < arrayX.Length; j++)
                    {
                        if (arrayX[j] == 0 || arrayX[j] == 1)
                        {
                            f = true;
                        }
                        else
                        {
                            f = false;
                            break;
                        }
                    }
                    if (f==true)
                    {
                        if (arrayX.Sum()>=2)
                        {
                            temp++;
                        }
                    }
                }
                Console.WriteLine(temp);


            }
        }
    }
}