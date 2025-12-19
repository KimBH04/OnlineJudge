int t = int.Parse(Console.ReadLine()!);

using var sw = new StreamWriter(Console.OpenStandardOutput());
while (t-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int n = int.Parse(inputs[0]),
        k = int.Parse(inputs[1]);

    if (k == 1)
    {
        if (n == 2 || n == 3)
        {
            sw.Write(-1);
        }
        else
        {
            for (int i = 2; i <= n; i += 2)
            {
                sw.Write($"{i} ");
            }
            for (int i = 1; i <= n; i += 2)
            {
                sw.Write($"{i} ");
            }
        }
    }
    else
    {
        for (int i = 1; i <= n; i++)
        {
            sw.Write($"{i} ");
        }
    }
    sw.WriteLine();
}
