using System;

namespace A._Wrong_Subtraction___Problem___977A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var temp = input.Split(' ');

            var n = Convert.ToInt32(temp[0]);
            var k = Convert.ToInt32(temp[1]);

            if ((n>=2 && n<=Math.Pow(10,9)) && (k>=1 && k<=50))
            {
                for (int i = 0; i < k; i++)
                {
                    var temp2 = n.ToString();
                    if (temp2[temp2.Length-1]=='0')
                    {
                        n /= 10;
                    }
                    else
                    {
                        n -= 1;
                    }
                }

                Console.WriteLine(n);
            }
        }
    }
}
