using System;

namespace Problem___467A___A._George_and_Accommodation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            if (n>=1 && n<=100)
            {
                var roomNumber = 0;

                for (int i = 0; i < n; i++)
                {
                    int[] x = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    var p = x[0];
                    var q = x[1];

                    if ((q>=0 && q<=100) && (p>=0 && p<=100))
                    {
                        if ( q - p >=2 )
                        {
                            roomNumber++;
                        }
                    }
                }

                Console.WriteLine(roomNumber);

            }
        }
    }
}