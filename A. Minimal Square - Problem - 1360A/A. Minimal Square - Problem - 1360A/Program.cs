int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split();

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    int min = Math.Min(a, b);
    int max = Math.Max(a, b);

    if (2 * min >= max) Console.WriteLine(Math.Pow(min * 2, 2));
    else Console.WriteLine(Math.Pow(max, 2));
}