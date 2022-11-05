using System;

namespace Problem___25A___A._IQ_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n>=3 && n<=100)
            {
                int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (x.Length==n)
                {
                    bool f = false;
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i]<=100)
                        {
                            f = false;
                        }
                        else
                        {
                            f = true;
                            break;
                        }
                    }

                    if (f!=true)
                    {
                        int countEven = 0;
                        int countOdd = 0;

                        foreach (var v in x)
                        {
                            if (v%2==0)
                            {
                                countEven++;
                            }
                            else
                            {
                                countOdd++;
                            }
                        }

                        int index = 0;
                        int index2 = 0;
                        if (countOdd>countEven)
                        {
                            for (int i = 0; i < x.Length; i++)
                            {
                                if (x[i]%2==0)
                                {
                                    index = i + 1;
                                    break;
                                }
                            }

                            Console.WriteLine(index);
                        }
                        else if (countEven>countOdd)
                        {
                            for (int i = 0; i < x.Length; i++)
                            {
                                if (x[i]%2!=0)
                                {
                                    index2 = i + 1;
                                    break;
                                }
                            }

                            Console.WriteLine(index2);
                        }
                        
                    }
                    
                }
            }
        }
    }
}