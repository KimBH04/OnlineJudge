int n = int.Parse(Console.ReadLine()!);
int[,] paper = new int[n, n];
int[] counts = new int[3];

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        paper[i, j] = int.Parse(inputs[j]);
    }
}

Cut(paper, counts, 0, 0, n);
Console.WriteLine(counts[0]);
Console.WriteLine(counts[1]);
Console.WriteLine(counts[2]);

static void Cut(int[,] paper, int[] counts, int r, int c, int n)
{
    int[] sums = { 0, 0, 0 };
    for (int i = r; i < r + n; i++)
    {
        for (int j = c; j < c + n; j++)
        {
            sums[paper[i, j] + 1]++;
        }
    }

    if (sums[0] == n * n)
    {
        counts[0]++;
        return;
    }
    if (sums[1] == n * n)
    {
        counts[1]++;
        return;
    }
    if (sums[2] == n * n)
    {
        counts[2]++;
        return;
    }

    int tri = n / 3;
    for (int i = r; i < r + n; i += tri)
    {
        for (int j = c; j < c + n; j += tri)
        {
            Cut(paper, counts, i, j, tri);
        }
    }
}