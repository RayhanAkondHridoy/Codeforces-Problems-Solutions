using System;

namespace Problem___318A___A._Even_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            long part,output;
            string s=Console.ReadLine();
            string[] values=s.Split(' ');
            long n=long.Parse(values[0]);
            long k=long.Parse(values[1]);

            if(n%2==0)
            {
                part=n/2;
            }
            else
            {
                part=(n/2)+1;
            }

            if(k<=part)
            {
                output=(2*k)-1;
            }
            else
            {
                output=(k-part)*2;
            }

            Console.WriteLine(output);

        }
    }
}