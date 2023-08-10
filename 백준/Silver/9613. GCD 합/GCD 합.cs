int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]);

    input = input[1..];
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = int.Parse(input[i]);
    }

    long r = 0;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            r += GCD(a[i], a[j]);
        }
    }

    Console.WriteLine(r);
}

static int GCD(int a, int b)
{
    if (a < b)
        (a, b) = (b, a);

    while (b > 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}
