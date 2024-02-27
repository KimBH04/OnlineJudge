int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int r = int.Parse(inputs[0]), c = int.Parse(inputs[1]);
    int rmin = int.MaxValue, rmax = int.MinValue;
    int cmin = int.MaxValue, cmax = int.MinValue;

    char[,] latteArt = new char[r, c];

    for (int i = 0; i < r; i++)
    {
        string input = Console.ReadLine()!;
        for (int j = 0; j < c; j++)
        {
            latteArt[i, j] = input[j];
            if (input[j] == '#')
            {
                rmin = i < rmin ? i : rmin;
                rmax = i > rmax ? i : rmax;
                cmin = j < cmin ? j : cmin;
                cmax = j > cmax ? j : cmax;
            }
        }
    }

    if (rmax - rmin != cmax - cmin)
    {
        Console.WriteLine(0);
        continue;
    }

    int len = rmax - rmin + 1;
    int testLen = len * 2;
    char[,] testArt = new char[testLen, testLen];
    for (int i = 0; i < testLen; i++)
    {
        for (int j = 0; j < testLen; j++)
        {
            testArt[i, j] = '.';
        }
    }

    for (int i = 0; i < len - 1; i++)
    {
        for (int j = 0; j < testLen; j++)
        {
            testArt[i, j] = testArt[testLen - i - 1, j] = testArt[j, i] = testArt[j, testLen - i - 1] = '#';
        }

        if (IsMatch(latteArt, testArt, rmin, cmin,   0,   0, len) ||
            IsMatch(latteArt, testArt, rmin, cmin, len,   0, len) ||
            IsMatch(latteArt, testArt, rmin, cmin,   0, len, len) ||
            IsMatch(latteArt, testArt, rmin, cmin, len, len, len))
        {
            Console.WriteLine(1);
            goto Matched;
        }
    }
    Console.WriteLine(0);
Matched:;
}

static bool IsMatch(char[,] main, char[,] test, int mainR, int mainC, int testR, int testC, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            char m;
            try
            {
                m = main[mainR + i, mainC + j];
            }
            catch
            {
                return false;
            }

            if (m != test[testR + i, testC + j])
            {
                return false;
            }
        }
    }
    return true;
}
