int n = int.Parse(Console.ReadLine()!);
bool[,] visited = new bool[n, n];

string[] inputs = Console.ReadLine()!.Split();
int sr = int.Parse(inputs[0]),
    sc = int.Parse(inputs[1]),
    er = int.Parse(inputs[2]),
    ec = int.Parse(inputs[3]);

Queue<(int, int)> queue = new();
queue.Enqueue((sr, sc));
visited[sr, sc] = true;

(int, int)[] dir = { (-2, -1), (-2, 1), (0, -2), (0, 2), (2, -1), (2, 1) };
int cnt = 0;
while (queue.Count > 0)
{
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        var (row, col) = queue.Dequeue();
        if (row == er && col == ec)
        {
            Console.WriteLine(cnt);
            return;
        }

        foreach (var (r, c) in dir)
        {
            int tr = row + r;
            int tc = col + c;
            if (0 <= tr && tr < n && 0 <= tc && tc < n && !visited[tr, tc])
            {
                visited[tr, tc] = true;
                queue.Enqueue((tr, tc));
            }
        }
    }

    cnt++;
}

Console.WriteLine(-1);