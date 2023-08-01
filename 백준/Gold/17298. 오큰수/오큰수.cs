using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(Console.ReadLine()!);
string[] a = Console.ReadLine()!.Split();

Stack<int> stack = new(), output = new();
foreach (string s in a.Reverse())
{
    int x = int.Parse(s);

    while (stack.Count > 0)
    {
        if (x < stack.Peek())
        {
            output.Push(stack.Peek());
            stack.Push(x);
            break;
        }
        else
        {
            stack.Pop();
        }
    }

    if (stack.Count < 1)
    {
        output.Push(-1);
        stack.Push(x);
    }
}

while (n-- > 0)
{
    sw.Write(output.Pop() + " ");
}
