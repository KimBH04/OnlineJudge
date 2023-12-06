int[,] map = new int[1001, 1001];

int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++)
{
    string[] paper = Console.ReadLine()!.Split();
    int x1 = int.Parse(paper[0]),
        y1 = int.Parse(paper[1]),
        x2 = int.Parse(paper[2]),
        y2 = int.Parse(paper[3]);

    for (int j = 0; j < x2; j++)
    {
        for (int k = 0; k < y2; k++)
        {
            map[x1 + j, y1 + k] = i;
        }
    }
}

for (int i = 1; i <= n; i++)
{
    int r = 0;
    foreach (int x in map)
    {
        if (x == i)
        {
            r++;
        }
    }
    Console.WriteLine(r);
}
