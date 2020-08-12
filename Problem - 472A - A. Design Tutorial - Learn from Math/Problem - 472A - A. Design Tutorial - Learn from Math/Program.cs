using System;

namespace Problem___472A___A._Design_Tutorial___Learn_from_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n>=12 && n<=Math.Pow(10,6))
            {
                int x = 0;
                bool temp3 = false;
                int output1 = 0;
                int output2 = 0;
                for (int i = 4; i < n; i+=2)
                {
                    int temp = n - i;

                    int temp2 = 0;
                    for (int j = temp; j > 2; j--)
                    {
                        if (temp%j==0)
                        {
                            temp2++;
                            if (temp2>=2)
                            {
                                x = temp + i;
                                if (x==n)
                                {
                                    output1 = i;
                                    output2 = temp;
                                    temp3 = true;
                                    break; 
                                }
                                
                            }
                        }
                    }
                    if (temp3==true)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{output1} {output2}");

            }
        }
    }
}