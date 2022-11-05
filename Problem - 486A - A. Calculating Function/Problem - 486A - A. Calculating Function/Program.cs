using System;

namespace Problem___486A___A._Calculating_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var input = long.Parse(Console.ReadLine());

            if (input>=1 && input<=1000000000000000)
            {
                var sum = 0;

                for (var i = 1; i <= input; i++)
                {
                    if (i%2!=0)
                    {
                        sum -= i;
                    }
                    else if (i%2==0)
                    {
                        sum += i;
                    }
                    
                }

                Console.WriteLine(sum);*/
            
            
            
            long n =Convert.ToInt64(Console.ReadLine());    

            if(n % 2 == 0) Console.WriteLine(n/2);

            else Console.WriteLine((-(n+1)/2));

                

            
        }
    }
}