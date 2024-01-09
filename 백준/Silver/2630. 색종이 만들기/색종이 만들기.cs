int n = int.Parse(Console.ReadLine()!);
bool[,] paper = new bool[n, n];

for (int i = 0; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < n; j++)
    {
        paper[i, j] = inputs[j] == "1";
    }
}

int white = 0;
int blue = 0;
Paper(paper, 0, 0, n, ref white, ref blue);
Console.WriteLine(white);
Console.WriteLine(blue);

static void Paper(bool[,] paper, int row, int col, int n, ref int white, ref int blue)
{
    bool wit = false;
    bool blu = true;

    for (int r = row; r < row + n; r++)
    {
        for (int c = col; c < col + n; c++)
        {
            wit |= paper[r, c];
            blu &= paper[r, c];
        }
    }

    if (!wit)
    {
        white++;
        return;
    }
    if (blu)
    {
        blue++;
        return;
    }

    int half = n >> 1;
    Paper(paper, row, col, half, ref white, ref blue);
    Paper(paper, row, col + half, half, ref white, ref blue);
    Paper(paper, row + half, col, half, ref white, ref blue);
    Paper(paper, row + half, col + half, half, ref white, ref blue);
}
