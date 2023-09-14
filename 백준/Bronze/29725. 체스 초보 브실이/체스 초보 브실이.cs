int w = 0, b = 0;

for (int i = 0; i < 8; i++)
{
    string s = Console.ReadLine()!;
    foreach (char c in s)
    {
        switch (c)
        {
            case 'P':
                w++;
                break;
            case 'p':
                b++;
                break;

            case 'N':
            case 'B':
                w += 3;
                break;
            case 'n':
            case 'b':
                b += 3;
                break;

            case 'R':
                w += 5;
                break;
            case 'r':
                b += 5;
                break;

            case 'Q':
                w += 9;
                break;
            case 'q':
                b += 9;
                break;

            default:
                break;
        }
    }
}

Console.WriteLine(w - b);