using System;
using System.Linq;

namespace Problem___479A___A._Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = Convert.ToDecimal(Console.ReadLine());
            decimal b = Convert.ToDecimal(Console.ReadLine());
            decimal c = Convert.ToDecimal(Console.ReadLine());

            if ((a >= 1 && a<=10)&&(b >= 1 && b<=10)&&(c >= 1 && c<=10))
            {
                decimal w = a+b*c;
                decimal x = a*(b+c);
                decimal y = a*b*c;
                decimal z = (a+b)*c;
                decimal zz = a + b + c;

                decimal[] array = new[] {w, x, y, z, zz};
                decimal output = array.Max();

                Console.WriteLine(output);
            } 
        }
    }
}
