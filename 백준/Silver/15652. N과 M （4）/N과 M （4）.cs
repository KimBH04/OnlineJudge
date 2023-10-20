string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

BackTracking(new int[m], 1, n, 0, m);

static void BackTracking(int[] arr, int start, int end, int m, int depth)
{
    if (m == depth)
    {
        Console.WriteLine(string.Join(' ', arr));
    }
    else
    {
        for (int i = start; i <= end; i++)
        {
            arr[m] = i;
            BackTracking(arr, i, end, m + 1, depth);
        }
    }
}
