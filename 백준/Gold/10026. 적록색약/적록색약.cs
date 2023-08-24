int n = int.Parse(Console.ReadLine()!);
string[] map = new string[n];
bool[,] v1 = new bool[n, n], v2 = new bool[n, n];
for (int i = 0; i < n; i++)
{
    map[i] = Console.ReadLine()!;
    for (int j = 0; j < n; j++)
    {
        v1[i, j] = false;
        v2[i, j] = false;
    }
}

int[,] dir = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
int r = 0, c = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (!v1[i, j])
        {
            NonColorWeakness(map, v1, dir, i, j, n, map[i][j]);
            r++;
        }
        if (!v2[i, j])
        {
            ColorWeakness(map, v2, dir, i, j, n, map[i][j]);
            c++;
        }
    }
}

Console.WriteLine(r + " " + c);

static void NonColorWeakness(string[] map, bool[,] v, int[,] dir, int x, int y, int n, char color)
{
    v[x, y] = true;
    for (int i = 0; i < 4; i++)
    {
        if (x + dir[i, 0] < n && x + dir[i, 0] >= 0 && y + dir[i, 1] < n && y + dir[i, 1] >= 0)
        {
            if (map[x + dir[i, 0]][y + dir[i, 1]] == color && !v[x + dir[i, 0], y + dir[i, 1]])
            {
                NonColorWeakness(map, v, dir, x + dir[i, 0], y + dir[i, 1], n, color);
            }
        }
    }
}

static void ColorWeakness(string[] map, bool[,] v, int[,] dir, int x, int y, int n, char color)
{
    v[x, y] = true;
    for (int i = 0; i < 4; i++)
    {
        if (x + dir[i, 0] < n && x + dir[i, 0] >= 0 && y + dir[i, 1] < n && y + dir[i, 1] >= 0)
        {
            if (color == 'B')
            {
                if (map[x + dir[i, 0]][y + dir[i, 1]] == color && !v[x + dir[i, 0], y + dir[i, 1]])
                {
                    ColorWeakness(map, v, dir, x + dir[i, 0], y + dir[i, 1], n, color);
                }
            }
            else
            {
                if ((map[x + dir[i, 0]][y + dir[i, 1]] == 'R' || map[x + dir[i, 0]][y + dir[i, 1]] == 'G') &&
                    !v[x + dir[i, 0], y + dir[i, 1]])
                {
                    ColorWeakness(map, v, dir, x + dir[i, 0], y + dir[i, 1], n, color);
                }
            }
        }
    }
}
