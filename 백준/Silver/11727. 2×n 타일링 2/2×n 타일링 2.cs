int[] t = new int[1001];
t[0] = t[1] = 1;
for (int i = 2; i < 1001; i++)
{
    t[i] = (t[i - 1] + t[i - 2] * 2) % 10007;
}

int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(t[n]);