var input = Console.ReadLine().Split();

int n = int.Parse(input[0]);
int m = int.Parse(input[1]);
int k = int.Parse(input[2]);

if (n > m || n > k) Console.WriteLine("NO");
else Console.WriteLine("YES");