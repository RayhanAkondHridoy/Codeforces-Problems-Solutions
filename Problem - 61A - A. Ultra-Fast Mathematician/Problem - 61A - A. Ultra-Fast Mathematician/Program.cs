using System;

namespace Problem___61A___A._Ultra_Fast_Mathematician
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine();
            var y = Console.ReadLine();

            var z = "";

            if ((x.Length<=100) && (x.Length==y.Length))
            {
                for (var i = 0; i < x.Length; i++)
                {
                    if ((x[i]=='0' && y[i] =='1') || (x[i]=='1' && y[i] =='0'))
                    {
                        z += '1';
                    }
                    else
                    {
                        z += '0';
                    }
                }

                Console.WriteLine(z);
            }

        }
    }
}