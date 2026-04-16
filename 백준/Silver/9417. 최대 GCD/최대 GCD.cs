int n = int.Parse(Console.ReadLine()!);

while (n-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    int m = input.Length;
    int[] a = new int[m];
    for (int i = 0; i < m; i++)
    {
        a[i] = Math.Abs(int.Parse(input[i]));
    }

    int max = int.MinValue;

    for (int i = 0; i < m - 1; i++)
    {
        for (int j = i + 1; j < m; j++)
        {
            max = Math.Max(max, GCD(a[i], a[j]));
        }
    }
    
    Console.WriteLine(max);
}

static int GCD(int a, int b)
{
    if (a < b)
    {
        (a, b) = (b, a);
    }

    while (b > 0)
    {
        (a, b) = (b, a % b);
    }

    return a;
}
