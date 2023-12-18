using StreamWriter sw = new(Console.OpenStandardOutput());

bool[] appeared = new bool[1000001];

int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

int[] nums = new int[n];
int[] shoubu = new int[1000001];
for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(inputs[i]);
    appeared[nums[i]] = true;
}

foreach (int i in nums)
{
    for (int j = i; j < 1000001; j += i)
    {
        if (appeared[j])
        {
            shoubu[i]++;
            shoubu[j]--;
        }
    }
}

foreach (int i in nums)
{
    sw.Write(shoubu[i] + " ");
}
