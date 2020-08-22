using System;

namespace A._Chat_room___problem___58A
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = "hello";

            var input = Console.ReadLine();
            if (input.Length>=1 && input.Length<=100)
            {
                int count = 0;
                int x = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i]==hello[x])
                    {
                        count++;
                        x++;
                        if (count==5)
                        {
                            break;
                        }
                    }
                }
                if (count==5)
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
