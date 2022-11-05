using System;

namespace A._Boy_or_Girl___Problem___236A
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputName = Console.ReadLine().ToLower();

            if (inputName.Length>=1 && inputName.Length<=100)
            {
                var name2 = " ";
                for (int i = 0; i < inputName.Length; i++)
                {
                    int c = 0;
                    for (int j = 0; j < name2.Length; j++)
                    {
                        if (inputName[i] == name2[j])
                        {
                            c++;
                            break;
                        }
                    }
                    if (c==0)
                    {
                        name2 += inputName[i];
                    }
                }
                if ((name2.Length-1) % 2 == 0 )
                {
                    Console.WriteLine("CHAT WITH HER!");
                }
                else
                {
                    Console.WriteLine("IGNORE HIM!");
                }
            }
        }
    }
}
