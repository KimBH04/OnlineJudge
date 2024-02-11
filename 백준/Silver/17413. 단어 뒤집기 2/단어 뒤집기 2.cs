using StreamWriter sw = new(Console.OpenStandardOutput());

string s = Console.ReadLine()!;

Stack<char> output = new();
bool isTag = false;
foreach (char c in s)
{
    if (c == '<')
    {
        sw.Write(string.Join(string.Empty, output));
        output.Clear();
        isTag = true;
    }
    else if (c == '>')
    {
        sw.Write(c);
        isTag = false;
        continue;
    }

    if (isTag)
    {
        sw.Write(c);
    }
    else
    {
        if (c == ' ')
        {
            sw.Write(string.Join(string.Empty, output) + " ");
            output.Clear();
        }
        else
        {
            output.Push(c);
        }
    }
}

sw.Write(string.Join(string.Empty, output));