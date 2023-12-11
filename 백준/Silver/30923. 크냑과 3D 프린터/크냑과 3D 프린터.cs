int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

long f = n + n;
int[] h = new int[n];
for (int i = 0; i < n; i++)
{
    h[i] = int.Parse(inputs[i]);
    f += h[i] + h[i];
}

for (int i = 1; i < n; i++)
{
    f += Math.Abs(h[i] - h[i - 1]);
}

Console.WriteLine(f + h[0] + h[^1]);