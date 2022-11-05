int q = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < q; i++)
{
    string[] input = Console.ReadLine().Split();

    var n = long.Parse(input[0]);
    var a = long.Parse(input[1]);
    var b = int.Parse(input[2]);
    long m = 0;

    if (a <= b / 2) m = n * a;
    else
    {
        if (n % 2 == 0) m = n / 2 * b;
        else m = (n - 1) / 2 * b + a;
    }
    Console.WriteLine(m);
}