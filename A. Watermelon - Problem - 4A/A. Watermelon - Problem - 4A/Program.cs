using System;

namespace A._Watermelon___Problem___4A
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = Convert.ToInt32(Console.ReadLine());
            if (w>=1 && w<=100)
            {
                if (w<=2 || w%2 !=0) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }
    }
}
