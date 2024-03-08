string s = Console.ReadLine()!;
char cursor = 'A';

int r = 0;
foreach (char c in s)
{
    int diff = Math.Abs(cursor - c);
    if (diff > 13)
    {
        r += 26 - diff;
    }
    else
    {
        r += diff;
    }
    cursor = c;
}

Console.WriteLine(r);