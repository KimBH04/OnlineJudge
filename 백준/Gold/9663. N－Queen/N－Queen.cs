int n = int.Parse(Console.ReadLine()!);
bool[,] board = new bool[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        board[i, j] = false;
    }
}

Console.WriteLine(Queen(n, 0, board));

static int Queen(int n, int m, bool[,] board)
{
    if (n == m) return 1;

    bool[,] temp = new bool[n, n];
    Array.Copy(board, temp, n * n);

    int r = 0;
    for (int i = 0; i < n; i++)
    {
        if (board[i, m]) continue;

        for (int j = 0; j < n; j++)
        {
            board[i, j] = true;
            board[j, m] = true;
        }

        for (int x = 1, y = 1; x < n && y < n; x++, y++)
        {
            if (i + x < n)
            {
                if (m + y < n)
                {
                    board[i + x, m + y] = true;
                }
                if (m - y >= 0)
                {
                    board[i + x, m - y] = true;
                }
            }
            if (i - x >= 0)
            {
                if (m + y < n)
                {
                    board[i - x, m + y] = true;
                }
                if (m - y >= 0)
                {
                    board[i - x, m - y] = true;
                }
            }
        }

        r += Queen(n, m + 1, board);
        Array.Copy(temp, board, n * n);
    }

    return r;
}
