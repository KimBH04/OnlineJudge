int n = int.Parse(Console.ReadLine()!);
int[,] s = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        s[i, j] = int.Parse(inputs[j]);
    }
}

int m = n / 2;

int min = BackTracking(s, Enumerable.Repeat(false, n).ToArray(), 0, n, 0, m);
Console.WriteLine(min);

static int BackTracking(int[,] s, bool[] arr, int start, int end, int m, int depth)
{
    if (m == depth)
    {
        int teamS = 0;
        int teamL = 0;
        for (int i = 0; i < end - 1; i++)
        {
            for (int j = i + 1; j < end; j++)
            {
                if (arr[i] == arr[j])
                {
                    if (arr[i])
                    {
                        teamS += s[i, j] + s[j, i];
                    }
                    else
                    {
                        teamL += s[i, j] + s[j, i];
                    }
                }
            }
        }

        return Math.Abs(teamS - teamL);
    }
    else
    {
        int r = int.MaxValue;
        for (int i = start; i < end; i++)
        {
            arr[i] = true;
            int bt = BackTracking(s, arr, i + 1, end, m + 1, depth);
            r = bt < r ? bt : r;
            arr[i] = false;
        }
        return r;
    }
}
