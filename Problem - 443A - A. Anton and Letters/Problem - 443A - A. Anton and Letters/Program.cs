using System;

namespace Problem___443A___A._Anton_and_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input.Length<=1000)
            {
                if (input[0]=='{' && input[input.Length-1] == '}')
                {
                    int count = 0;

                    for (int a = 'a'; a <= 'z'; a++)
                    {
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input[i]==a)
                            {
                                count++;
                                break;
                            }
                        }
                    }

                    Console.WriteLine(count);
                }
                
            }
        }
    }
}