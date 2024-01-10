using StreamWriter sw = new(Console.OpenStandardOutput());

while (true)
{
    string[] inputs = Console.ReadLine()!.Split();
    int k = int.Parse(inputs[0]);
    if (k == 0)
    {
        break;
    }

    int[] ints = new int[k];
    for (int i = 0; i < k; i++)
    {
        ints[i] = int.Parse(inputs[i + 1]);
    }

    Lotto(sw, ints, new int[6], 0, k, 0, 6);
    sw.WriteLine();
}

static void Lotto(StreamWriter sw, int[] arr, int[] nums, int start, int n, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', nums));
    }
    else
    {
        for (int i = start; i < n; i++)
        {
            nums[m] = arr[i];
            Lotto(sw, arr, nums, i + 1, n, m + 1, depth);
        }
    }
}
