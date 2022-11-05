using System;

namespace Problem___59A___A._Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            if (s.Length>=1 && s.Length<=100)
            {
                var countLow = 0;
                var countUpp = 0;

                for (int i = 0; i < s.Length; i++)
                {
                    var temp = Convert.ToString(s[i]);
                    var temp2 = temp.ToUpper();

                    if (string.Compare(temp,temp2)==0)
                    {
                        countUpp++;
                    }
                    else
                    {
                        countLow++;
                    }
                }

                if (countLow<countUpp)
                {
                    s = s.ToUpper();
                }
                else
                {
                    s = s.ToLower();
                }

                Console.WriteLine(s);
                
            }
        }
    }
}