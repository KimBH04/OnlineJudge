using StreamWriter sw = new(Console.OpenStandardOutput());

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
    int idx = int.Parse(inputs[i]);
    nums[idx]++;
}

BackTracking(sw, nums, new int[m], 0, m);

static void BackTracking(StreamWriter sw, int[] nums, int[] arr, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', arr));
    }
    else
    {
        for (int i = 0; i < 10001; i++)
        {
            if (nums[i] > 0)
            {
                arr[m] = i;
                nums[i]--;
                BackTracking(sw, nums, arr, m + 1, depth);
                nums[i]++;
            }
        }
    }
}
