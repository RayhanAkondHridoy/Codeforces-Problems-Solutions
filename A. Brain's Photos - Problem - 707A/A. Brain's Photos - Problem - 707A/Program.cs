string[] nm = Console.ReadLine().Split();
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int bwc = 0;
int c = 0;

for (int i = 0; i < n; i++)
{
    string[] tempString = Console.ReadLine().Split();

    for (int j = 0; j < m; j++)
    {
        char tempChar = char.Parse(tempString[j]);
        bool b = tempChar.Equals('B');
        bool w = tempChar.Equals('W');
        bool g = tempChar.Equals('G');

        if (b || w || g)
            bwc++;
        else c++;
    }
}

if (c != 0) Console.WriteLine("#Color");
else Console.WriteLine("#Black&White");