string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

int[,] a = new int[n + 1, m + 1];
Array.Clear(a);

for (int i = 1; i <= n; i++)
{
    input = Console.ReadLine()!.Split();
    for (int j = 1; j <= m; j++)
    {
        a[i, j] = int.Parse(input[j - 1]);
        a[i, j] += a[i, j - 1];
    }
}

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= m; j++)
    {
        a[i, j] += a[i - 1, j];
    }
}

int k = int.Parse(Console.ReadLine()!);
while (k-- > 0)
{
    input = Console.ReadLine()!.Split();
    int i = int.Parse(input[0]),
        j = int.Parse(input[1]),
        x = int.Parse(input[2]),
        y = int.Parse(input[3]);

    Console.WriteLine(a[x, y] - a[i - 1, y] - a[x, j - 1] + a[i - 1, j - 1]);
}
