using System;

namespace Problem__510A___A._Fox_And_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var n = array[0];
            var m = array[1];

            
            if ((n>=3 && n<=50) && (m>=3 && m<=50))
            {
                if (n%2 !=0)
                {
                    var f = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= m; j++)
                        {
                            if (i%2 != 0)
                            {
                                if (j == m)
                                {
                                    Console.WriteLine("#");
                                }

                                else
                                {
                                    Console.Write("#");
                                }
                            }
                            else
                            {
                                if (f==1)
                                {
                                    if (j==m)
                                    {
                                        Console.WriteLine("#");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                                else if (f==0)
                                {
                                    if (j==1)
                                    {
                                        Console.Write("#");
                                    }
                                    else if (j==m)
                                    {
                                        Console.WriteLine(".");
                                    }
                                    else
                                    {
                                        Console.Write(".");
                                    }
                                }
                            }
                        }

                        if (i%2==0)
                        {
                            if (f==1)
                            {
                                f = 0;
                            }
                            else
                            {
                                f = 1;
                            }
                        }
                        
                    }
                    
                }
            }
        }
    }
}