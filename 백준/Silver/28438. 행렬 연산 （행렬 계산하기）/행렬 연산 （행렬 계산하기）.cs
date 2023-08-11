using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] input = sr.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]),
    q = int.Parse(input[2]);

int[] ro = Enumerable.Repeat(0, n).ToArray(),
      cu = Enumerable.Repeat(0, m).ToArray();

while (q-- > 0)
{
    input = sr.ReadLine()!.Split();
    int a = int.Parse(input[0]),
        b = int.Parse(input[1]) - 1,
        c = int.Parse(input[2]);

    if (a < 2)
    {
        ro[b] += c;
    }
    else
    {
        cu[b] += c;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sw.Write($"{ro[i] + cu[j]} ");
    }
    sw.WriteLine();
}
