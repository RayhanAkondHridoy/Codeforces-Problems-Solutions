using System;

namespace A._Football___Problem___96A
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------//
            ////    Annotation:    A. Football (Problem - 96A - Codeforces)    ////
            //------------------------------------------------------------------//


            var inputString = Console.ReadLine();
            if (inputString.Length>=1 && inputString.Length<=100 )
            {
                int count = 0;
                int count2 = 0;
                int temp = 0;

                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == '0')
                    {
                        count++;
                        count2 = 0;
                    }
                    else
                    {
                        count2++;
                        count = 0;
                    }

                    if (count == 7 || count2 == 7)
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp==1)
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