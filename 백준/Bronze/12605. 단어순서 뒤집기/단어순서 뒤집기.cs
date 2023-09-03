using static System.Console;
int n = int.Parse(ReadLine()!);
for (int i = 1; i <= n; i++)
{
    Stack<string> s = new();
    foreach (string sw in ReadLine()!.Split())
    {
        s.Push(sw);
    }

    Write($"Case #{i}:");
    while (s.Count > 0)
    {
        Write(" " + s.Pop());
    }
    WriteLine();
}
