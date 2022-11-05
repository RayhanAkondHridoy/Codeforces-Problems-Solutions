string[] ab = Console.ReadLine().Split();

int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
int Factorial = 1;

if (a < b)
{
    for (int i = 1; i < a + 1; i++)
    {
        Factorial *= i;
    }
}
else
{
    for (int i = 1; i < b + 1; i++)
    {
        Factorial *= i;
    }
}

Console.WriteLine(Factorial);