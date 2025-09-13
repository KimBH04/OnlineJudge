int n = int.Parse(Console.ReadLine()!);
var arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

Console.WriteLine(BackTracking(arr, n, new int[n], 0, new bool[n]));

static int BackTracking(int[] arr, int n, int[] resArr, int depth, bool[] v)
{
    int res = 0;
    if (n == depth)
    {
        for (int i = 1; i < n; i++)
        {
            res += Math.Abs(resArr[i - 1] - resArr[i]);
        }
    }
    else
    {
        for (int i = 0; i < n; i++)
        {
            if (v[i])
            {
                continue;
            }

            v[i] = true;
            resArr[depth] = arr[i];
            int bt = BackTracking(arr, n, resArr, depth + 1, v);
            if (res < bt)
            {
                res = bt;
            }
            v[i] = false;
        }
    }

    return res;
}
