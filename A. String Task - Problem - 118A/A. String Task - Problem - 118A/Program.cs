using System;

namespace A._String_Task___Problem___118A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();

            var vowels = "aeiouy";

            var output = "";

            for (int i = 0; i < input.Length; i++)
            {
                bool f = true;
                for (int j = 0; j < vowels.Length; j++)
                {
                    
                    if (input[i] == vowels[j])
                    {
                        f = false;
                        break;
                    }
                }
                if (f == true)
                {
                    output += "."+input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
