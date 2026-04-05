string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), l = int.Parse(inputs[1]);
int t = 0;
int m = 0;
while (n-- > 0)
{
    string z = Console.ReadLine()!;
    int r = 0;
    int p = 0;
    for (int i = 0; i < l; i++)
    {
        if (z[i] == '1')
        {
            p++;
        }
        else if (p > 0)
        {
            r++;
            p = 0;
        }
    }

    if (p > 0)
    {
        r++;
    }
    
    if (r > m)
    {
        m = r;
        t = 1;
    }
    else if (r == m)
    {
        t++;
    }
}

Console.WriteLine($"{m} {t}");