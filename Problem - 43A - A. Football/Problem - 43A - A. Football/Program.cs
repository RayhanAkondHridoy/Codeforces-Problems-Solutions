﻿using System;

namespace Problem___43A___A._Football
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int teamA = 1, teamB = 0;
            string t1 = Console.ReadLine();
            string t2 = null;
            for(int i = 1; i < T; i++)
            {
                string s = Console.ReadLine();
                if (t1 == s)
                {
                    teamA++;
                }
                else {
                    if (t2 == null)
                        t2 = s;
                    teamB++;
                }
            }

            Console.WriteLine((teamA>teamB)?t1:t2);
        }
    }
}