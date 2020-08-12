using System;

namespace Problem___734A___A._Anton_and_Danik
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine().ToUpper();

            if (n>=1 && n<=100000)
            {
                if (n==s.Length)
                {
                    var danik = 0;
                    var anton = 0;
                    
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i]=='A')
                        {
                            anton++;
                        }
                        else if (s[i]=='D')
                        {
                            danik++;
                        }
                    }
                    if (anton>danik)
                    {
                        Console.WriteLine("Anton");
                    }
                    else if (danik>anton)
                    {
                        Console.WriteLine("Danik");
                    }
                    else if (anton==danik)
                    {
                        Console.WriteLine("Friendship");
                    }

                }
            }
            

        }
    }
}