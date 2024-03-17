int n = int.Parse(Console.ReadLine()!);
int r = 0;
while (n-- > 0)
{
    string input = Console.ReadLine()!;

    Stack<char> stack = new(input.Length);
    foreach (char c in input)
    {
        if (stack.Count > 0 && stack.Peek() == c)
        {
            stack.Pop();
        }
        else
        {
            stack.Push(c);
        }
    }
    if (stack.Count == 0)
    {
        r++;
    }
}
Console.WriteLine(r);