int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split();

    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    int s;

    if (a > b)
    {
        if ((a - b) % 2 == 0) s = 1;
        else s = 2;
    }
    else if (a < b)
    {
        if ((a - b) % 2 == 0) s = 2;
        else s = 1;
    }
    else s = 0;

    Console.WriteLine(s);
}