string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] nums = new int[n];
for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(inputs[i]);
}

nums = nums.Distinct().ToArray();
Array.Sort(nums);

using StreamWriter sw = new(Console.OpenStandardOutput());
BackTracking(sw, nums, new int[m], nums.Length, 0, m);

static void BackTracking(StreamWriter sw, int[] nums, int[] arr, int len, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', arr));
    }
    else
    {
        for (int i = 0; i < len; i++)
        {
            arr[m] = nums[i];
            BackTracking(sw, nums, arr, len, m + 1, depth);
        }
    }
}
