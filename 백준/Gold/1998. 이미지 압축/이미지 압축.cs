string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);
int size = 1;
while (size < n || size < m)
{
    size <<= 1;
}

bool[,] image = new bool[size, size];
for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine()!;
    for (int j = 0; j < m; j++)
    {
        image[i, j] = input[j] == '1';
    }
}

int total = 0, compress = 0;
Quad(image, new HashSet<string>(), 0, 0, size, ref total, ref compress);
Console.WriteLine($"{total} {compress}");

static string Quad(bool[,] image, HashSet<string> hash, int r, int c, int n, ref int total, ref int compress)
{
    total++;
    bool allZero = true, allOne = true;
    for (int i = r; i < r + n; i++)
    {
        for (int j = c; j < c + n; j++)
        {
            allZero ^= allZero && image[i, j];
            allOne &= image[i, j];
        }
    }

    if (allZero)
    {
        compress++;
        return "0";
    }
    if (allOne)
    {
        compress++;
        return "1";
    }

    int compCnt = 1, half = n / 2;
    string quad =
        '(' +
        Quad(image, hash, r,        c,        half, ref total, ref compCnt) +
        Quad(image, hash, r + half, c,        half, ref total, ref compCnt) +
        Quad(image, hash, r,        c + half, half, ref total, ref compCnt) +
        Quad(image, hash, r + half, c + half, half, ref total, ref compCnt) +
        ')';

    if (hash.Add(quad))
    {
        compress += compCnt;
    }

    return quad;
}
