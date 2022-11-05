using System;

namespace Problem___122A___A._HQ9Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = Console.ReadLine();
            if (p.Length>=1 && p.Length<=100)
            {
                bool temp = true;

                for (int i = 0; i < p.Length; i++)
                {
                    var x = Convert.ToInt32(p[i]);
                    if (x>=33 && x<=126)
                    {
                        temp = true;
                    }
                    else
                    {
                        temp = false;
                        break;
                    }
                }
                if (temp==true)
                {
                    bool b = false;
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (p[i]=='H' || p[i]=='Q' || p[i]=='9')
                        {
                            b = true;
                        }
                    }
                    if (b!=true)
                    {
                        Console.WriteLine("NO");
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
            }
        }
    }
}