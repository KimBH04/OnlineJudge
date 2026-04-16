void IncreaseArray()
{
    using var sr = new StreamReader(Console.OpenStandardInput());
    using var sw = new StreamWriter(Console.OpenStandardOutput());

    var input = sr.ReadLine()!.Split();
    int n = int.Parse(input[0]),
        m = int.Parse(input[1]),
        k = int.Parse(input[2]);

    if (n + m - 1 > k)
    {
        sw.WriteLine("NO");
        return;
    }

    sw.WriteLine("YES");
    for (int i = 1; i <= n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            sw.Write(i + j + " ");
        }
        sw.WriteLine();
    }
}

IncreaseArray();