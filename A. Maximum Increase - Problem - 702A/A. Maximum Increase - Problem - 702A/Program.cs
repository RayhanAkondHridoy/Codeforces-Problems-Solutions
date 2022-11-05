int n = Convert.ToInt32(Console.ReadLine());
string[] input = Console.ReadLine().Split();

int bc = 1;
int mc = bc;
for (int i = 0; i < n - 1; i++)
{
    int x = int.Parse(input[i]);
    int y = int.Parse(input[i + 1]);

    if (x < y)
    {
        bc++;

        if (bc > mc)
        {
            mc = bc;
        }
    }
    else
    {
        bc = 1;
    }

}

Console.WriteLine(mc);