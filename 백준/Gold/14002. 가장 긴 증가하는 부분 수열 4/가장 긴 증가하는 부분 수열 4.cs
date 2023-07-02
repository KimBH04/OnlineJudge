int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();

int[] a = new int[n];
int[] dp = new int[n];
int[] indexes = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(input[i]);
    dp[i] = 1;
    indexes[i] = -1;
}

for (int i = 1; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (a[j] < a[i] && dp[i] <= dp[j])
        {
            dp[i] = dp[j] + 1;
            indexes[i] = j;
        }
    }
}

int max = 1;
int idx = 0;
for (int i = 0; i < n; i++)
{
    if (max < dp[i])
    {
        max = dp[i];
        idx = i;
    }
}

Console.WriteLine($"{max}\n{Output(a, indexes, idx)}");

static string Output(int[] a, int[] indexes, int idx)
{
    if (indexes[idx] == -1)
        return a[idx] + "";

    return Output(a, indexes, indexes[idx]) + " " + a[idx];
}
