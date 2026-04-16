string[][] gaji = new string[10][];
for (int i = 0; i < 10; i++)
{
    gaji[i] = Console.ReadLine()!.Split();
    string color = gaji[i][0];
    foreach (string s in gaji[i][1..])
    {
        if (color != s)
        {
            goto Re;
        }
    }
    Console.WriteLine(1);
    return;
Re:;
}

for (int i = 0; i < 10; i++)
{
    string color = gaji[0][i];
    for (int j = 1; j < 10; j++)
    {
        if (color != gaji[j][i])
        {
            goto Re;
        }
    }
    Console.WriteLine(1);
    return;
Re:;
}

Console.WriteLine(0);