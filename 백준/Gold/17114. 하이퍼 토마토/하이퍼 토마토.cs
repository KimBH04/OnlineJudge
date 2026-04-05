string[] inputs = Console.ReadLine()!.Split();
int m = int.Parse(inputs[0]),
    n = int.Parse(inputs[1]),
    o = int.Parse(inputs[2]),
    p = int.Parse(inputs[3]),
    q = int.Parse(inputs[4]),
    r = int.Parse(inputs[5]),
    s = int.Parse(inputs[6]),
    t = int.Parse(inputs[7]),
    u = int.Parse(inputs[8]),
    v = int.Parse(inputs[9]),
    w = int.Parse(inputs[10]);

int[,,,,,,,,,,] tomato = new int[m, n, o, p, q, r, s, t, u, v, w];
Queue<(int, int, int, int, int, int, int, int, int, int, int)> queue= new();
for (int a = 0; a < w; a++)
{
    for (int b = 0; b < v; b++)
    {
        for (int c = 0; c < u; c++)
        {
            for (int d = 0; d < t; d++)
            {
                for (int e = 0; e < s; e++)
                {
                    for (int f = 0; f < r; f++)
                    {
                        for (int g = 0; g < q; g++)
                        {
                            for (int h = 0; h < p; h++)
                            {
                                for (int i = 0; i < o; i++)
                                {
                                    for (int j = 0; j < n; j++)
                                    {
                                        inputs = Console.ReadLine()!.Split();
                                        for (int k = 0; k < m; k++)
                                        {
                                            tomato[k, j, i, h, g, f, e, d, c, b, a] = int.Parse(inputs[k]);
                                            if (tomato[k, j, i, h, g, f, e, d, c, b, a] == 1)
                                            {
                                                queue.Enqueue((a, b, c, d, e, f, g, h, i, j, k));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

int[,] dir = {
    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },

    { -1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, -1, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, -1, 0, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, -1, 0, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, -1, 0, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, -1, 0, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, -1, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, -1, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, -1, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, -1, 0 },
    { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -1 }
};

while (queue.Count > 0)
{
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        var (a, b, c, d, e, f, g, h, i, j, k) = queue.Dequeue();

        for (int l = 0; l < 22; l++)
        {
            int ta = a + dir[l, 0],
                tb = b + dir[l, 1],
                tc = c + dir[l, 2],
                td = d + dir[l, 3],
                te = e + dir[l, 4],
                tf = f + dir[l, 5],
                tg = g + dir[l, 6],
                th = h + dir[l, 7],
                ti = i + dir[l, 8],
                tj = j + dir[l, 9],
                tk = k + dir[l, 10];

            if (0 <= ta && ta < w &&
                0 <= tb && tb < v &&
                0 <= tc && tc < u &&
                0 <= td && td < t &&
                0 <= te && te < s &&
                0 <= tf && tf < r &&
                0 <= tg && tg < q &&
                0 <= th && th < p &&
                0 <= ti && ti < o &&
                0 <= tj && tj < n &&
                0 <= tk && tk < m)
            {
                if (tomato[tk, tj, ti, th, tg, tf, te, td, tc, tb, ta] == 0)
                {
                    tomato[tk, tj, ti, th, tg, tf, te, td, tc, tb, ta] = tomato[k, j, i, h, g, f, e, d, c, b, a] + 1;
                    queue.Enqueue((ta, tb, tc, td, te, tf, tg, th, ti, tj, tk));
                }
            }
        }
    }
}

int max = 0;
foreach (int i in tomato)
{
    if (i == 0)
    {
        Console.WriteLine(-1);
        return;
    }

    if (max < i)
    {
        max = i;
    }
}

Console.WriteLine(max - 1);