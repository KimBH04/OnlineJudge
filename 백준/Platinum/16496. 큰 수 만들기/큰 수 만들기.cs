using System.Numerics;

int n = int.Parse(Console.ReadLine()!);
string[] s = Console.ReadLine()!.Split();

for (int i = n - 1; i > 0; i--)
{
    for (int j = 0; j < i; j++)
    {
        if (ulong.Parse(s[j] + s[j + 1]) < ulong.Parse(s[j + 1] + s[j]))
        {
            (s[j], s[j + 1]) = (s[j + 1], s[j]);
        }
    }
}

Console.WriteLine(BigInteger.Parse(string.Join(string.Empty, s)));