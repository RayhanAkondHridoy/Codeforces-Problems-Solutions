using System;

namespace A._Petya_and_Strings___Problem___112A
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = Console.ReadLine().ToLower();
            var string2 = Console.ReadLine().ToLower();

            if ((string1.Length >= 1 && string1.Length <= 100) && (string2.Length >= 1 && string2.Length <= 100))
            {
                if (string1.Length == string2.Length)
                {
                    if (string1.CompareTo(string2)==0)
                    {
                        Console.WriteLine("0");
                    }
                    else if (string1.CompareTo(string2)>0)
                    {
                        Console.WriteLine("1");
                    }
                    else if (string.Compare(string2,string1)>0)
                    {
                        Console.WriteLine("-1");
                    }
                }
            }
        }
    }
}
