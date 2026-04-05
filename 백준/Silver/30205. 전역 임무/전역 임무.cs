string[] input = Console.ReadLine()!.Split();
long n = long.Parse(input[0]),
    p = long.Parse(input[2]);

while (n-- > 0)
{
    string[] s = Console.ReadLine()!.Split();
    int d = 0;

    List<long> enemy = new();
    foreach (string i in s)
    {
        long j = long.Parse(i);

        if (j < 0)
        {
            d++;
        }
        else
        {
            enemy.Add(j);
        }
    }

    enemy.Sort();

    foreach (long e in enemy)
    {
        while (p < e)
        {
            p *= 2;
            if (--d < 0)
            {
                Console.WriteLine(0);
                return;
            }
        }

        p += e;
    }

    p <<= d;
}

Console.WriteLine(1);