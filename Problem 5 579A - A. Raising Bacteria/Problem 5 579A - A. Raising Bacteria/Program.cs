using System;

namespace Problem_5_579A___A._Raising_Bacteria
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string input = Convert.ToString(int.Parse(Console.ReadLine()), 2);
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1')
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}