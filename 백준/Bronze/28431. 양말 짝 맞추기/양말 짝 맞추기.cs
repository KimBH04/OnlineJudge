int[] s = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
for (int i = 0; i < 5; i++)
{
    s[int.Parse(Console.ReadLine()!)]++;
}

for (int i = 0; i < 10; i++)
{
    if (s[i] % 2 == 1)
    {
        Console.WriteLine(i);
        break;
    }
}
