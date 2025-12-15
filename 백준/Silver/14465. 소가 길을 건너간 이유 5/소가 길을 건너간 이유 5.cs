string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]),
    k = int.Parse(inputs[1]),
    b = int.Parse(inputs[2]);

int[] arr = new int[n];
while (b-- > 0)
{
    arr[int.Parse(Console.ReadLine()!) - 1] = 1;
}

int[] sumArr = new int[n + 1];
for (int i = 0; i < n; i++)
{
    sumArr[i + 1] = sumArr[i] + arr[i];
}

int min = int.MaxValue;
for (int i = k; i <= n; i++)
{
    int v = sumArr[i] - sumArr[i - k];
    if (min > v)
    {
        min = v;
    }
}

Console.WriteLine(min);