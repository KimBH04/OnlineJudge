int[] map = Enumerable.Range(0, 101).ToArray();
bool[] visited = Enumerable.Repeat(false, 101).ToArray();

string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]),
    m = int.Parse(inputs[1]);

while (n-- > 0)
{
    inputs = Console.ReadLine()!.Split();
    int x = int.Parse(inputs[0]),
        y = int.Parse(inputs[1]);

    map[x] = y;
}

while (m-- > 0)
{
    inputs = Console.ReadLine()!.Split();
    int u = int.Parse(inputs[0]),
        v = int.Parse(inputs[1]);

    map[u] = v;
}

Queue<int> queue = new();
queue.Enqueue(1);
visited[1] = true;

int cnt = -1;
while (queue.Count > 0)
{
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        int i = queue.Dequeue();
        if (i == 100)
        {
            queue.Clear();
            break;
        }

        if (i + 1 < 101 && !visited[i + 1])
        {
            visited[i + 1] = true;
            queue.Enqueue(map[i + 1]);
        }

        if (i + 2 < 101 && !visited[i + 2])
        {
            visited[i + 2] = true;
            queue.Enqueue(map[i + 2]);
        }

        if (i + 3 < 101 && !visited[i + 3])
        {
            visited[i + 3] = true;
            queue.Enqueue(map[i + 3]);
        }

        if (i + 4 < 101 && !visited[i + 4])
        {
            visited[i + 4] = true;
            queue.Enqueue(map[i + 4]);
        }

        if (i + 5 < 101 && !visited[i + 5])
        {
            visited[i + 5] = true;
            queue.Enqueue(map[i + 5]);
        }

        if (i + 6 < 101 && !visited[i + 6])
        {
            visited[i + 6] = true;
            queue.Enqueue(map[i + 6]);
        }
    }
    cnt++;
}

Console.WriteLine(cnt);