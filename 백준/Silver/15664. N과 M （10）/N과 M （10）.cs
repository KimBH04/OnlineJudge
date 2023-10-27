string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] nums = new int[10001];
for (int i = 0; i < 10001; i++)
{
    nums[i] = 0;
}

for (int i = 0; i < n; i++)
{
    int j = int.Parse(inputs[i]);
    nums[j]++;
}

using StreamWriter sw = new(Console.OpenStandardOutput());
BackTracking(sw, nums, new int[m], 0, 0, m);

static void BackTracking(StreamWriter sw, int[] nums, int[] arr, int start, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', arr));
    }
    else
    {
        for (int i = start; i < 10001; i++)
        {
            if (nums[i] > 0)
            {
                nums[i]--;
                arr[m] = i;
                BackTracking(sw, nums, arr, i, m + 1, depth);
                nums[i]++;
            }
        }
    }
}
