int[] gwa = { 0, 0, 0, 0 };
int p = int.Parse(Console.ReadLine()!);
while (p-- > 0)
{
    string[] input = Console.ReadLine()!.Split();
    int g = int.Parse(input[0]),
        c = int.Parse(input[1]),
        n = int.Parse(input[2]);

    if (g == 1)
    {
        gwa[3]++;
    }
    else if (c < 3)
    {
        gwa[0]++;
    }
    else
    {
        gwa[c - 2]++;
    }
}

foreach (int i in gwa)
{
    Console.WriteLine(i);
}
