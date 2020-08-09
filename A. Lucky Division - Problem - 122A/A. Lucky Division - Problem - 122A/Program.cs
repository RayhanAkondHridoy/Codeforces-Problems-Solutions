using System;

namespace A._Lucky_Division___Problem___122A
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------//
            ////    Annotation:    A. Lucky Division (Problem - 122A - Codeforces)    ////
            //-------------------------------------------------------------------------//
            
            
            var n = Convert.ToInt32(Console.ReadLine());

            if (n>=1 && n<=1000)
            {
                if (n % 4 ==0 || n % 7 ==0 || n % 44 ==0 || n % 47 ==0 || n % 74 ==0 || n % 77 ==0 || n % 444 ==0 || n % 447 ==0 || n % 474 ==0 || n % 477 ==0 || n % 744 ==0 || n % 4 ==0 || n % 747 ==0 || n % 777==0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                
            }
        }
    }
}