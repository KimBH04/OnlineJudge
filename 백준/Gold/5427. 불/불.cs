using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

(int, int)[] dir = { (0, 1), (0, -1), (1, 0), (-1, 0) };

int t = int.Parse(sr.ReadLine()!);
while (t-- > 0)
{
    string[] inputs = sr.ReadLine()!.Split();
    int w = int.Parse(inputs[0]), h = int.Parse(inputs[1]);

    bool[,] visited = new bool[h, w];
    bool[,] fireVisited = new bool[h, w];
    Queue<(int, int)> queue = new();
    Queue<(int, int)> fire = new();

    string[] map = new string[h];
    for (int i = 0; i < h; i++)
    {
        map[i] = sr.ReadLine()!;
        for (int j = 0; j < w; j++)
        {
            if (map[i][j] == '*')
            {
                fireVisited[i, j] = true;
                fire.Enqueue((i, j));
            }
            else if (map[i][j] == '@')
            {
                visited[i, j] = true;
                queue.Enqueue((i, j));
            }
        }
    }

    int cnt = 1;
    while (queue.Count > 0)
    {
        int fireCnt = fire.Count;
        while (fireCnt-- > 0)
        {
            var (r, c) = fire.Dequeue();
            foreach (var d in dir)
            {
                int tr = r + d.Item1;
                int tc = c + d.Item2;
                if (0 <= tr && tr < h && 0 <= tc && tc < w && map[tr][tc] != '#' && !fireVisited[tr, tc])
                {
                    fireVisited[tr, tc] = true;
                    fire.Enqueue((tr, tc));
                }
            }
        }

        int qCnt = queue.Count;
        while (qCnt-- > 0)
        {
            var (r, c) = queue.Dequeue();
            if (r == 0 || r == h - 1 || c == 0 || c == w - 1)
            {
                sw.WriteLine(cnt);
                goto Escaped;
            }

            foreach (var d in dir)
            {
                int tr = r + d.Item1;
                int tc = c + d.Item2;
                if (0 <= tr && tr < h && 0 <= tc && tc < w && map[tr][tc] != '#' && !visited[tr, tc] && !fireVisited[tr, tc])
                {
                    visited[tr, tc] = true;
                    queue.Enqueue((tr, tc));
                }
            }
        }
        cnt++;
    }

    sw.WriteLine("IMPOSSIBLE");
Escaped:;
}
