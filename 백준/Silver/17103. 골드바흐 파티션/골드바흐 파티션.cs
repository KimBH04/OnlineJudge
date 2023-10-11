bool[] eratos = Enumerable.Repeat(true, 1000001).ToArray();
eratos[0] = eratos[1] = false;
for (int i = 2; i < 1000001; i++)
{
    if (eratos[i])
    {
        for (int j = i + i; j < 1000001; j += i)
        {
            eratos[j] = false;
        }
    }
}

int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    int r = 0;
    for (int i = 0, j = n; i <= j; i++, j--)
    {
        if (eratos[i] && eratos[j])
        {
            r++;
        }
    }
    Console.WriteLine(r);
}