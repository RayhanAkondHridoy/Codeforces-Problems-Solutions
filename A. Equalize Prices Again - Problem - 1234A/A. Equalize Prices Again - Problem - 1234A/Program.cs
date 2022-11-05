int.TryParse(Console.ReadLine(), out int q);

for (int i = 0; i < q; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    var p = Console.ReadLine().Split();
    double sum = 0;

    for (int j = 0; j < n; j++)
    {
        sum += int.Parse(p[j]);
    }

    double apc = Math.Ceiling(sum / n);

    Console.WriteLine(apc);
}