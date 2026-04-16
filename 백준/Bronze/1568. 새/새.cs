var n = int.Parse(Console.ReadLine()!);
var cnt = 0;

for (int i = 1; n > 0; i++)
{
    cnt++;

    if (n < i)
    {
        i = 1;
    }

    n -= i;
}

Console.WriteLine(cnt);