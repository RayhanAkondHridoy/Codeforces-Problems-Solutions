using System;

namespace A._Bear_and_Big_Brother___Problem___791A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var temp = input.Split(' ');

            var a = int.Parse(temp[0]);
            var b = int.Parse(temp[1]);

            if (a<=b && a>=1 && b<=10)
            {
                var years = 0;

                while (a<=b)
                {
                    a *= 3;
                    b *= 2;
                    years++;
                }
                Console.WriteLine(years);
            }
        }
    }
}
