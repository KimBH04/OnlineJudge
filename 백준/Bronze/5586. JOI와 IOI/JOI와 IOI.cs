var c = Console.ReadLine().ToCharArray();
int joi = 0, ioi = 0;

for (int i = 0; i < c.Length - 2; i++)
{
    if (c[i] == 'J' && c[i + 1] == 'O' && c[i + 2] == 'I')
    {
        joi++;
    }
    if (c[i] == 'I' && c[i + 1] == 'O' && c[i + 2] == 'I')
    {
        ioi++;
    }
}

Console.WriteLine(joi + "\n" + ioi);