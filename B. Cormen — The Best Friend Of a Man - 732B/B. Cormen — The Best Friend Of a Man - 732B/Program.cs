int[] nk = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] w = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int n = nk[0];
int k = nk[1];
int counter = 0;

for (int i = 0; i < w.Length - 1; i++)
{
    while (w[i] + w[i + 1] < k)
    {
        counter++;
        w[i + 1]++;
    }
}

Console.WriteLine(counter);

foreach (int day in w)
{
    Console.Write(day + " ");
}