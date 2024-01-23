int k = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();
int w = int.Parse(inputs[0]), h = int.Parse(inputs[1]);

int[,] map = new int[h, w];
for (int i = 0; i < h; i++)
{
    inputs = Console.ReadLine()!.Split();
    for (int j = 0; j < w; j++)
    {
        map[i, j] = int.Parse(inputs[j]);
    }
}

Queue<(int, int, int)> queue = new();
queue.Enqueue((0, 0, k));

bool[,,] visited = new bool[h, w, k + 1];
visited[0, 0, 0] = true;

(int, int)[]
    dir = { (0, 1), (0, -1), (1, 0), (-1, 0) },
    horse = { (1, 2), (2, 1), (1, -2), (2, -1), (-1, 2), (-2, 1), (-1, -2), (-2, -1) };
int cnt = 0;
while (queue.Count > 0)
{
    int qcnt = queue.Count;
    while (qcnt-- > 0)
    {
        var (row, col, hor) = queue.Dequeue();

        if (row == h - 1 && col == w - 1)
        {
            Console.WriteLine(cnt);
            return;
        }

        foreach (var (r, c) in dir)
        {
            int tr = row + r;
            int tc = col + c;
            if (0 <= tr && tr < h && 0 <= tc && tc < w && map[tr, tc] != 1 && !visited[tr, tc, hor])
            {
                visited[tr, tc, hor] = true;
                queue.Enqueue((tr, tc, hor));
            }
        }

        if (hor > 0)
        {
            hor--;
            foreach (var (r, c) in horse)
            {
                int tr = row + r;
                int tc = col + c;
                if (0 <= tr && tr < h && 0 <= tc && tc < w && map[tr, tc] != 1 && !visited[tr, tc, hor])
                {
                    visited[tr, tc, hor] = true;
                    queue.Enqueue((tr, tc, hor));
                }
            }
        }
    }
    cnt++;
}

Console.WriteLine(-1);