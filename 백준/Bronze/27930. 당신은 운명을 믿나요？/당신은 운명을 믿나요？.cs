var input = Console.ReadLine()!;

string korea, yonsei;
korea = yonsei = string.Empty;

foreach (char c in input)
{
    int yonlen = yonsei.Length, kolen = korea.Length;

    if (c == 'K' && korea.Length == 0)
        korea += c;
    if (c == 'Y' && yonsei.Length == 0)
        yonsei += c;

    if (c == 'O')
    {
        if (kolen > 0)
            if (korea[^1] == 'K')
                korea += c;

        if (yonlen > 0)
            if (yonsei[^1] == 'Y')
                yonsei += c;
    }

    if (kolen > 0)
        if (c == 'R' && korea[^1] == 'O')
            korea += c;

    if (yonlen > 0)
        if (c == 'N' && yonsei[^1] == 'O')
            yonsei += c;

    if (yonlen > 0)
        if (c == 'S' && yonsei[^1] == 'N')
            yonsei += c;

    if (c == 'E')
    {
        if (kolen > 0)
            if (korea[^1] == 'R')
                korea += c;

        if (yonlen > 0)
            if (yonsei[^1] == 'S')
                yonsei += c;
    }

    if (kolen > 0)
        if (c == 'A' && korea[^1] == 'E')
            korea += c;

    if (yonlen > 0)
        if (c == 'I' && yonsei[^1] == 'E')
            yonsei += c;

    if (korea == "KOREA")
    {
        Console.WriteLine("KOREA");
        break;
    }
    else if (yonsei == "YONSEI")
    {
        Console.WriteLine("YONSEI");
        break;
    }
}
