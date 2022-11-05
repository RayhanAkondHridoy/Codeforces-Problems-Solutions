string[] rolls = Console.ReadLine().Split();

int y = int.Parse(rolls[0]);
int w = int.Parse(rolls[1]);
int max = Math.Max(y, w);
int wo = 6 - max + 1;

if (wo % 6 == 0) Console.WriteLine("1/1");
else if (wo % 3 == 0) Console.WriteLine(wo / 3 + "/" + 2);
else if (wo % 2 == 0) Console.WriteLine(wo / 2 + "/" + 3);
else Console.WriteLine(wo + "/" + 6);