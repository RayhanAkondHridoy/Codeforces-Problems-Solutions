using System;

namespace A._Soldier_and_Bananas___Problem__546A
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------__--//
            ////    Annotation:    A. Soldier and Bananas (Problem - 546A - Codeforces)    ////
            //------------------------------------------------------------------------------//
            
            
            
            int [] array1 = new int[3];
            var input = Console.ReadLine();
            var inputSpl = input.Split(' ');

            for (int i = 0; i < 3; i++)
            {
                array1[i] = int.Parse(inputSpl[i]);
            }
            int k = array1[0], n = array1[1], w = array1[2];
            if (((k>=1 && k<=1000) && (w>=1 && w<=1000)) && (n>=0 && n<= Math.Pow(10,9)))
            {
                int d = 0;
                for (int i = 1; i <= w ; i++)
                {
                    d += k * i;
                }

                if (d<=n)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(d-n);
                }
            }
        }
    }
}