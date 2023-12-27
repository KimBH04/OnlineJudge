int n = int.Parse(Console.ReadLine()!.Split()[0]);

int r = 0;
while (n-- > 0)
{
    int o = 0, x = 0;
    foreach (char c in Console.ReadLine()!)
    {
        if (c == 'O')
        {
            o++;
        }
        else
        {
            x++;
        }
    }

    if (o > x)
    {
        r++;
    }
}

Console.WriteLine(r);