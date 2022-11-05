int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    long[] xy = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
    long[] ab = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
    long x = xy[0];
    long y = xy[1];
    long a = ab[0];
    long b = ab[1];
    long cost = 0;
    long max = Math.Max(x, y);
    long min = Math.Min(x, y);
    long dbc = min;
    long doc = max - min;

    if (2 * a < b) cost = dbc * 2 * a + doc * a;
    else cost = dbc * b + doc * a;

    Console.WriteLine(cost);
}