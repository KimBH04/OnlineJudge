(int r, int c)[] dir = { (-1, 0), (0, 1), (1, 0), (0, -1) };

string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

input = Console.ReadLine()!.Split();
int r = int.Parse(input[0]),
    c = int.Parse(input[1]),
    d = int.Parse(input[2]);

int[,] map = new int[n, m];
for (int i = 0; i < n; i++)
{
    input = Console.ReadLine()!.Split();
    for (int j = 0; j < m; j++)
    {
        map[i, j] = int.Parse(input[j]);
    }
}

int cleaned = 0;
var rotate = (int n) => (n + 3) % 4;
var toBack = (int n) => (n + 2) % 4;
while (true)
{
    if (map[r, c] == 0)
    {
        cleaned++;
        map[r, c] = 2;
    }

    bool noCleaned = false;
    int origin = d;
    for (int i = 0; i < 4; i++)
    {
        d = rotate(d);
        if (map[r + dir[d].r, c + dir[d].c] == 0)
        {
            noCleaned = true;
            break;
        }
    }

    if (noCleaned)
    {
        r += dir[d].r;
        c += dir[d].c;
        continue;
    }

    d = origin;
    int back = toBack(d);
    int tr = r + dir[back].r;
    int tc = c + dir[back].c;
    if (map[tr, tc] != 1)
    {
        r = tr;
        c = tc;
    }
    else
    {
        break;
    }
}

Console.WriteLine(cleaned);