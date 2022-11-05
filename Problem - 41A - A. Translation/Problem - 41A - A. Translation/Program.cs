using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem___41A___A._Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToLower();
            var t = Console.ReadLine().ToLower();

            if ((s.Length>=1 && s.Length<=100) && (t.Length>=1 && t.Length<=100))
            {
                var tLength = t.Length - 1;
                var b = false;
                
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i]==t[tLength])
                    {
                        b = true;
                        tLength--;
                    }
                    else
                    {
                        b = false;
                        break;
                    }
                }

                if (b==true) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
