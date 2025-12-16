string a = Console.ReadLine()!;
string b = Console.ReadLine()!;
int al = a.Length;
int bl = b.Length;

int[,] lcs = new int[al + 1, bl + 1];
for (int i = 0; i < al; i++)
{
    for (int j = 0; j < bl; j++)
    {
        if (a[i] == b[j])
        {
            lcs[i + 1, j + 1] = lcs[i, j] + 1;
        }
        else
        {
            lcs[i + 1, j + 1] = Math.Max(lcs[i + 1, j], lcs[i, j + 1]);
        }
    }
}

Console.WriteLine(lcs[al, bl]);