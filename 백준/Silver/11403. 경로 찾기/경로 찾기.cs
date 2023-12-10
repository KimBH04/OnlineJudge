const int INF = 1 << 16;

int n = int.Parse(Console.ReadLine()!);
int[,] g = new int[n, n];

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        g[i, j] = int.Parse(inputs[j]);
        if (g[i, j] == 0)
        {
            g[i, j] = INF;
        }
    }
}

for (int m = 0; m < n; m++)
{
    for (int s = 0; s < n; s++)
    {
        for (int e = 0; e < n; e++)
        {
            if (g[s, e] > g[s, m] + g[m, e])
            {
                g[s, e] = g[s, m] + g[m, e];
            }
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write((g[i, j] < INF ? 1 : 0) + " ");
    }
    Console.WriteLine();
}
