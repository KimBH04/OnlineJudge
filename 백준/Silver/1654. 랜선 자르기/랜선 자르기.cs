string[] inputs = Console.ReadLine()!.Split();
int k = int.Parse(inputs[0]), n = int.Parse(inputs[1]);

int[] lans = new int[k];
for (int i = 0; i < k; i++)
{
    lans[i] = int.Parse(Console.ReadLine()!);
}

long left = 1, right = lans.Max();
while (left < right)
{
    long sum = left + right;
    long mid = sum - sum / 2;

    long cnt = 0;
    foreach (int lan in lans)
    {
        cnt += lan / mid;
    }

    if (cnt < n)
    {
        right = mid - 1;
    }
    else
    {
        left = mid;
    }
}

Console.WriteLine(left);