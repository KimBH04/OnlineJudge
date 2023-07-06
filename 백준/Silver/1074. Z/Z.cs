string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    r = int.Parse(input[1]),
    c = int.Parse(input[2]);

Console.WriteLine(Z(n, r, c, 0, 0));

static int Z(int n, int r, int c, int x, int y)
{
    if (x == c && y == r)
    {
        return 0;
    }

    int t = 0;
    int p = 1 << n;
    int b = p / 2;

    for (int i = y; i < y + p; i += b)
    {
        for (int j = x; j < x + p; j += b)
        {
            if (c < j + b && r < i + b)
            {
                t += Z(n - 1, r, c, j, i);
                goto here;
            }
            else
            {
                t += b * b;
            }
        }
    }

here:
    return t;
}
