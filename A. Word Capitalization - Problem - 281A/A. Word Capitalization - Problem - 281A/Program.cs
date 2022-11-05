using System;

namespace A._Word_Capitalization___Problem___281A
{
    class Program
    {
        static void Main(string[] args)
        {            
            var input = Console.ReadLine();
            if (input != null && !(input.Length <= Math.Pow(10, 3))) return;
            var output = "";
            if (input != null)
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 0)
                    {
                        output += input[i].ToString().ToUpper();
                    }
                    else
                    {
                        output += input[i];
                    }
                }
            Console.WriteLine(output);
        }
    }
}
