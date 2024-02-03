int n = int.Parse(Console.ReadLine()!);
int[] multis = new int[n];
int[] sums = new int[n];

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    multis[i] = int.Parse(inputs[0]);
    sums[i] = int.Parse(inputs[1]);
}

int min = int.MaxValue;
for (int m = 1; m <= n; m++)
{
    int value = BackTracking(multis, sums, 1, 0, 0, n, 0, m);
    min = min > value ? value : min;
}
Console.WriteLine(min);

static int BackTracking(int[] multis, int[] sums, int multi, int sum, int start, int n, int m, int depth)
{
    if (m == depth)
    {
        return Math.Abs(multi - sum);
    }
    else
    {
        int min = int.MaxValue;
        for (int i = start; i < n; i++)
        {
            int value = BackTracking(multis, sums, multi * multis[i], sum + sums[i], i + 1, n, m + 1, depth);
            min = min > value ? value : min;
        }
        return min;
    }
}
