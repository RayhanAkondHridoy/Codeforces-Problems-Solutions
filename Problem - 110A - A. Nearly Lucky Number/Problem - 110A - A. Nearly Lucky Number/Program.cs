using System;

namespace Problem___110A___A._Nearly_Lucky_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToDecimal(Console.ReadLine());
            if (n>=1 && n <= (decimal) Math.Pow(10,18))
            {
                var temp = n.ToString();
                var count = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i]=='4' || temp[i]=='7')
                    {
                        count++;
                    }
                }
                if (count == 4 || count == 7)
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