string s = Console.ReadLine()!;
bool[] bools = new bool[s.Length];

Function(s, bools, 0, s.Length, s.Length);

static void Function(string s, bool[] bools, int begin, int end, int len)
{
    if (begin == end)
    {
        return;
    }

    int idx = -1;
    int first = int.MaxValue;
    for (int i = begin; i < end; i++)
    {
        if (first > s[i])
        {
            first = s[i];
            idx = i;
        }
    }

    bools[idx] = true;
    for (int i = 0; i < len; i++)
    {
        if (bools[i])
        {
            Console.Write(s[i]);
        }
    }
    Console.WriteLine();
    Function(s, bools, idx + 1, end, len);
    Function(s, bools, begin, idx, len);
}
