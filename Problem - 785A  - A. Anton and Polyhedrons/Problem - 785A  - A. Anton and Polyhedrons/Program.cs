using System;

namespace Problem___785A____A._Anton_and_Polyhedrons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tetrahedron = 4
            // Cube = 6
            // Octahedron = 8
            // Dodecahedron = 12
            // Icosahedron = 20

            var n = int.Parse(Console.ReadLine());

            if (n>=1 && n<=200000)
            {
                int count = 0;

                for (int i = 0; i < n; i++)
                {
                    var input = Console.ReadLine();

                    if (input == "Tetrahedron")
                    {
                        count += 4;
                    }
                    else if (input == "Cube")
                    {
                        count += 6;
                    }
                    else if (input == "Octahedron")
                    {
                        count += 8;
                    }
                    else if (input == "Dodecahedron")
                    {
                        count += 12;
                    }
                    else if (input == "Icosahedron")
                    {
                        count += 20;
                    }
                }

                Console.WriteLine(count);
            }




        }
    }
}