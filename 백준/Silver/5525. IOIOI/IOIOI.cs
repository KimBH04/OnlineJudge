int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

int i = 0;
int r = 0;
while (i < m)
{
    if (s[i] == 'I')
    {
        i++;
        int c = 0;
        while (i < m - 1)
        {
            if (s[i] == 'O' && s[i + 1] == 'I')
            {
                c++;
            }
            else
            {
                i--;
                break;
            }

            if (c >= n)
            {
                r++;
            }

            i += 2;
        }
    }
    i++;
}

Console.WriteLine(r);