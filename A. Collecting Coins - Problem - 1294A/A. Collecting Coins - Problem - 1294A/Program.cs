int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split();

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int c = int.Parse(input[2]);
    int n = int.Parse(input[3]);
    int ct = a + b + c + n;
    int max = Math.Max(Math.Max(a, b), c);
    int td = max - a + max - b + max - c;

    if (ct % 3 == 0 && n >= td) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}