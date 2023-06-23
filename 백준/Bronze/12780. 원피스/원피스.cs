string h = Console.ReadLine()!;
string n = Console.ReadLine()!;
int hlen = h.Length;
int nlen = n.Length;

int r = 0;

for (int i = 0; i <= hlen - nlen; i++)
{
    if (h[i..(nlen + i)] == n)
    {
        r++;
    }
}

Console.WriteLine(r);