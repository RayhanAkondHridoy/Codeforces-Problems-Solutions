int n = Convert.ToInt32(Console.ReadLine());
int w = 0;

for (int i = 1; i < n; i++)
{
    if ((n - i) % i == 0)
    {
        w++;
    }
}

Console.WriteLine(w);