int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

var towers = new double[n];
for (int i = 0; i < n; i++)
{
    towers[i] = double.Parse(inputs[i]);
}

int max = 0;
for (int i = 0; i < n; i++)
{
    int cnt = 0;
    double diff = -1_000_000_000;
    for (int j = 1; j <= i; j++)
    {
        if (towers[i - j] - towers[i] > diff * j)
        {
            cnt++;
            diff = (towers[i - j] - towers[i]) / j;
        }
    }

    diff = -1_000_000_000;
    for (int j = 1; j < n - i; j++)
    {
        if (towers[i + j] - towers[i] > diff * j)
        {
            cnt++;
            diff = (towers[i + j] - towers[i]) / j;
        }
    }

    if (max < cnt)
    {
        max = cnt;
    }
}

Console.WriteLine(max);