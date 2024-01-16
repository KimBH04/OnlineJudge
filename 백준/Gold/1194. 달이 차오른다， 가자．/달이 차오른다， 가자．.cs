string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

Queue<(int, int, int)> queue = new();
string[] map = new string[n];
bool[,,] visited = new bool[n, m, 1 << 6];
for (int i = 0; i < n; i++)
{
    map[i] = Console.ReadLine()!;
    for (int j = 0; j < m; j++)
    {
        if (map[i][j] == '0')
        {
            visited[i, j, 0] = true;
            queue.Enqueue((i, j, 0));
        }
    }
}

int cnt = 0;
(int, int)[] dir = { (0, 1), (0, -1), (1, 0), (-1, 0) };
while (queue.Count > 0)
{
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        var (r, c, key) = queue.Dequeue(); 
        if (map[r][c] == '1')
        {
            Console.WriteLine(cnt);
            return;
        }

        foreach (var d in dir)
        {
            int tr = r + d.Item1;
            int tc = c + d.Item2;
            int ascii;
            if (0 <= tr && tr < n && 0 <= tc && tc < m && (ascii = map[tr][tc]) != '#' && !visited[tr, tc, key])
            {
                if (ascii >= 'a')
                {
                    int newKey = key | (1 << (ascii - 'a'));
                    visited[tr, tc, newKey] = true;
                    queue.Enqueue((tr, tc, newKey));
                }
                else if (ascii >= 'A')
                {
                    if ((key & (1 << (ascii - 'A'))) > 0)
                    {
                        visited[tr, tc, key] = true;
                        queue.Enqueue((tr, tc, key));
                    }
                }
                else
                {
                    visited[tr, tc, key] = true;
                    queue.Enqueue((tr, tc, key));
                }
            }
        }
    }
    cnt++;
}

Console.WriteLine(-1);