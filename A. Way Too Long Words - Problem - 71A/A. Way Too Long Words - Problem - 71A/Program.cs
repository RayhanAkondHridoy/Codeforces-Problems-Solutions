using System;

namespace A._Way_Too_Long_Words___Problem___71A
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------//
            ////    Annotation:    A. Way Too Long Words (Problem - 71A - Codeforces)    ////
            //----------------------------------------------------------------------------//



            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()?.ToLower();
                var output = "";
                if (input!=null)
                {
                    if (input.Length>=1 && input.Length<101)
                    {
                        if (input.Length>=11)
                        {
                            output += input[0].ToString();
                            output += (input.Length - 2).ToString();
                            output += input[input.Length-1];
                        }
                        else
                        {
                            output = input;
                        }
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}