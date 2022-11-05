int q = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < q; i++)
{
    var input = Console.ReadLine().Split();
    var a = long.Parse(input[0]);
    var b = long.Parse(input[1]);
    var c = long.Parse(input[2]);

    Console.WriteLine((a + b + c) / 2);
}