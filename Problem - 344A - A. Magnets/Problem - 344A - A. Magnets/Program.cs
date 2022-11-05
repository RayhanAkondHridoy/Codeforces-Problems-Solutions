using System;

namespace Problem___344A___A._Magnets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 100000)
            {
                string temp = "";

                var count = 0;
                var x = "";
                for (var i = 0; i < n; i++)
                {
                    var input = Console.ReadLine();
                    if (i==0)
                    {
                        x = input;
                        count++;
                    }
                    else if (input!=x)
                    {
                        count++;
                        x = input;
                    }
                    
                }

                Console.WriteLine(count);
            }
        }
    }
}