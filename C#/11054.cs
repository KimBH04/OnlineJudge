int n = int.Parse(Console.ReadLine()!);
int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int[] incDP = new int[n];

for (int i = 0; i < n; i++)
{
    incDP[i] = 1;
    for (int j = 0; j < i; j++)
    {
        if (arr[j] < arr[i] && incDP[j] >= incDP[i])
        {
            incDP[i] = incDP[j] + 1;
        }
    }
}

Array.Reverse(arr, 0, n);
int[] redDP = new int[n];

for (int i = 0; i < n; i++)
{
    redDP[i] = 1;
    for (int j = 0; j < i; j++)
    {
        if (arr[j] < arr[i] && redDP[j] >= redDP[i])
        {
            redDP[i] = redDP[j] + 1;
        }
    }
}

Array.Reverse(redDP, 0, n);
int max = 0;

for (int i = 0; i < n; i++)
{
    max = Math.Max(max, incDP[i] + redDP[i] - 1);
}

Console.WriteLine(max);