string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
int[] q = Enumerable.Repeat(0, m).ToArray();

while (n-- > 0)
{
    input = Console.ReadLine()!.Split();
    for (int i = 0; i < m; i++)
    {
        q[i] += int.Parse(input[i]);
    }
}

int a = int.Parse(Console.ReadLine()!);
int s = 0;
for (int i = 0; i < a; i++)
{
    s += q[i];
}
int r = s;

for (int i = 1; i <= m - a; i++)
{
    s += q[i + a - 1] - q[i - 1];
    r = r < s ? s : r;
}

Console.WriteLine(r);