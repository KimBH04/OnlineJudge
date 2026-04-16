using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine()!);

while (t-- > 0)
{
    bool error = false;
    int remover = 0;

    string p = sr.ReadLine()!;
    int n = int.Parse(sr.ReadLine()!);

    string[] input = sr.ReadLine()![1..^1].Split(',');

    List<int> x = new();
    for (int i = 0; i < n; i++)
    {
        x.Add(int.Parse(input[i]));
    }

    foreach (char i in p)
    {
        if (i == 'R')
        {
            remover *= -1;
            remover += n - 1;
        }
        else
        {
            if (n > 0)
            {
                x.RemoveAt(remover);
                remover -= remover > 0 ? 1 : 0;
                n--;
            }
            else
            {
                error = true;
                break;
            }
        }
    }

    if (remover > 0)
        x.Reverse();

    sw.WriteLine(error ? "error" : $"[{string.Join(',', x)}]");
}