int t = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] hm = Console.ReadLine().Split();
    int h = int.Parse(hm[0]);
    int m = int.Parse(hm[1]);
    int hr = 23 - h;
    int mr = 60 - m;
    Console.WriteLine(hr * 60 + mr);
}