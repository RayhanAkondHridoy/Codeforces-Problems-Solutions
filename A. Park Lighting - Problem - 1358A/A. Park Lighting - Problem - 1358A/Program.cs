int t = Convert.ToInt32(Console.ReadLine());

int output;

for (int i = 0; i < t; i++)
{
    string[] input = Console.ReadLine().Split();

    int n = int.Parse(input[0]);
    int m = int.Parse(input[1]);
    int s = m * n;

    if (s % 2 == 0) output = s / 2;
    else output = s / 2 + 1;

    Console.WriteLine(output);
}