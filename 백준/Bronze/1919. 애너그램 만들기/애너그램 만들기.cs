string a = Console.ReadLine()!;
string b = Console.ReadLine()!;

int[] alpha = new int[26];
foreach (int i in a)
{
    alpha[i - 97]++;
}
foreach (int i in b)
{
    alpha[i - 97]--;
}

int r = 0;
foreach (int i in alpha)
{
    if (i != 0)
    {
        r += i < 0 ? -i : i;
    }
}

Console.WriteLine(r);