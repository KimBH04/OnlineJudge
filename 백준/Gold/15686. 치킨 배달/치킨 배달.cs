string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

List<(int, int)> homes = new();
List<(int, int)> chicken = new();

for (int i = 0; i < n; i++)
{
    inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        if (inputs[j] == "1")
        {
            homes.Add((i, j));
        }
        else if (inputs[j] == "2")
        {
            chicken.Add((i, j));
        }
    }
}

int r = BackTracking(homes.ToArray(), chicken.ToArray(), new bool[chicken.Count], chicken.Count, 0, 0, chicken.Count - m);
Console.WriteLine(r);

static int BackTracking((int, int)[] homes, (int, int)[] chicken, bool[] isDeleted, int count, int start, int m, int depth)
{
    if (m == depth)
    {
        int totalDis = 0;
        foreach (var (r, c) in homes)
        {
            int min = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (!isDeleted[i])
                {
                    int dis = Math.Abs(r - chicken[i].Item1) + Math.Abs(c - chicken[i].Item2);
                    min = dis < min ? dis : min;
                }
            }
            totalDis += min;
        }
        return totalDis;
    }
    else
    {
        int min = int.MaxValue;
        for (int i = start; i < count; i++)
        {
            isDeleted[i] = true;

            int dis = BackTracking(homes, chicken, isDeleted, count, i + 1, m + 1, depth);
            min = dis < min ? dis : min;
            isDeleted[i] = false;
        }
        return min;
    }
}
