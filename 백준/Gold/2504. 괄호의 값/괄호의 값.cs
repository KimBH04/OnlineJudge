string s = Console.ReadLine()!;
Console.WriteLine(Brackets(s, 0, s.Length));

static int Brackets(string s, int begin, int end)
{
    if (begin == end)
    {
        return 1;
    }

    int result = 0;

    int count = 0;
    Stack<char> stack = new(end);
    for (int i = begin; i < end; i++)
    {
        switch (s[i])
        {
            case '(':
            case '[':
                count++;
                stack.Push(s[i]);
                break;

            case ')':
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    count--;
                    stack.Pop();

                    if (count == 0)
                    {
                        int r = Brackets(s, begin + 1, i) * 2;
                        if (r == 0)
                        {
                            return 0;
                        }
                        begin = i + 1;
                        result += r;
                    }
                }
                else
                {
                    return 0;
                }
            break;

            case ']':
                if (stack.Count > 0 && stack.Peek() == '[')
                {
                    count--;
                    stack.Pop();

                    if (count == 0)
                    {
                        int r = Brackets(s, begin + 1, i) * 3;
                        if (r == 0)
                        {
                            return 0;
                        }
                        begin = i + 1;
                        result += r;
                    }
                }
                else
                {
                    return 0;
                }
            break;
        }
    }

    if (stack.Count > 0)
    {
        return 0;
    }
    return result;
}
