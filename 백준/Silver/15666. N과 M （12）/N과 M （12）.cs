string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] tmp = new int[n];
for (int i = 0; i < n; i++)
{
    tmp[i] = int.Parse(inputs[i]);
}

int[] nums = tmp.Distinct().OrderBy(x => x).ToArray();

using StreamWriter sw = new(Console.OpenStandardOutput());
BackTracking(sw, nums, new int[m], 0, nums.Length, 0, m);

static void BackTracking(StreamWriter sw, int[] nums, int[] arr, int start, int end, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', arr));
    }
    else
    {
        for (int i = start; i < end; i++)
        {
            arr[m] = nums[i];
            BackTracking(sw, nums, arr, i, end, m + 1, depth);
        }
    }
}
