int n = int.Parse(Console.ReadLine()!);
int[,] map = new int[n, n];
for (int y = 0; y < n; y++)
{
    string input = Console.ReadLine()!;
    for (int x = 0; x < n; x++)
    {
        map[x, y] = input[x] - 48;
    }
}

Console.WriteLine(QuardTree(n, 0, 0));

string QuardTree(int n, int x, int y)
{
    int s = 0;
    for (int i = y; i < y + n; i++)
    {
        for (int j = x; j < x + n; j++)
        {
            s += map[j, i];
        }
    }

    if (s == 0)
    {
        return "0";
    }
    else if (s == n * n)
    {
        return "1";
    }
    else
    {
        n /= 2;
        return "("
            + QuardTree(n, x, y)
            + QuardTree(n, x + n, y)
            + QuardTree(n, x, y + n)
            + QuardTree(n, x + n, y + n)
            + ")";
    }
}
