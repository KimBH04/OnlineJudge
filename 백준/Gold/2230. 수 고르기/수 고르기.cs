string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(Console.ReadLine()!);
}

Array.Sort(a);

int left = 0, right = 0, r = int.MaxValue;
while (left <= right && right < n)
{
    int d = a[right] - a[left];

    if (d > m)
    {
        if (r > d)
            r = d;

        left++;
    }
    else if (d < m)
    {
        right++;
    }
    else
    {
        r = m;
        break;
    }
}

Console.WriteLine(r);