string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]), k = int.Parse(inputs[2]);

bool[,] visited = new bool[n, m];
while (k-- > 0)
{
    string[] obstacle = Console.ReadLine()!.Split();
    int y = int.Parse(obstacle[0]), x = int.Parse(obstacle[1]);
    visited[y, x] = true;
}

(int, int)[] oddDir = { (-1, 0), (-1, 1), (0, 1), (1, 1), (1, 0), (0, -1) };
(int, int)[] evenDir = { (-1, -1), (-1, 0), (0, 1), (1, 0), (1, -1), (0, -1) };
Queue<(int, int)> queue = new();
queue.Enqueue((0, 0));
visited[0, 0] = true;

int cnt = 0;
while (queue.Count > 0)
{
    int qcnt = queue.Count;
    while (qcnt-- > 0)
    {
        var (y, x) = queue.Dequeue();
        if (y == n - 1 && x == m - 1)
        {
            Console.WriteLine(cnt);
            return;
        }

        var dir = y % 2 == 1 ? oddDir : evenDir;
        foreach (var (row, col) in dir)
        {
            int ty = y + row;
            int tx = x + col;
            if (0 <= ty && ty < n && 0 <= tx && tx < m && !visited[ty, tx])
            {
                visited[ty, tx] = true;
                queue.Enqueue((ty, tx));
            }
        }
    }
    cnt++;
}

Console.WriteLine(-1);