var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), k = int.Parse(input[1]);

var s = new int[n + 1];
s[0] = 0;
input = Console.ReadLine()!.Split();
for (int i = 0; i < n; i++)
{
    s[i + 1] = s[i] + int.Parse(input[i]);
}

int max = int.MinValue;
for (int i = 0; k <= n; i++, k++)
{
    max = Math.Max(max, s[k] - s[i]);
}

Console.WriteLine(max);