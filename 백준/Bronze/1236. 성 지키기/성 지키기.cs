string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

char[,] castle = new char[n, m];
for (int r = 0; r < n; r++)
{
    string input = Console.ReadLine()!;
    for (int c = 0; c < m; c++)
    {
        castle[r, c] = input[c];
    }
}

int cnt = 0;
for (int r = 0; r < n; r++)
{
    for (int c = 0; c < m; c++)
    {
        for (int k = 0; k < n; k++)
        {
            if (castle[k, c] == 'X')
            {
                goto IsGuard;
            }
        }

        for (int k = 0; k < m; k++)
        {
            if (castle[r, k] == 'X')
            {
                goto IsGuard;
            }
        }

        castle[r, c] = 'X';
        cnt++;
    IsGuard:;
    }
}

for (int r = 0; r < n; r++)
{
    for (int k = 0; k < m; k++)
    {
        if (castle[r, k] == 'X')
        {
            goto IsGuard;
        }
    }

    castle[r, 0] = 'X';
    cnt++;
IsGuard:;
}

for (int c = 0; c < m; c++)
{
    for (int k = 0; k < n; k++)
    {
        if (castle[k, c] == 'X')
        {
            goto IsGuard;
        }
    }

    castle[0, c] = 'X';
    cnt++;
IsGuard:;
}

Console.WriteLine(cnt);