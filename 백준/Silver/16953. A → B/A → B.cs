bool[] visited = Enumerable.Repeat(false, 1_000_000_001).ToArray();

string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]), b = int.Parse(input[1]);

Console.WriteLine(BFS(a, b, visited));

static int BFS(int a, int b, bool[] visited)
{
    Queue<int> q = new();
    q.Enqueue(a);
    int cnt = 1;
    while (q.Count > 0)
    {
        int qcnt = q.Count;
        for (int i = 0; i < qcnt; i++)
        {
            long x = q.Dequeue();

            if (x == b)
            {
                return cnt;
            }

            if (x * 2 <= b)
            {
                if (!visited[x * 2])
                {
                    visited[x * 2] = true;
                    q.Enqueue((int)x * 2);
                }
            }

            if (x * 10 + 1 <= b)
            {
                if (!visited[x * 10 + 1])
                {
                    visited[x * 10 + 1] = true;
                    q.Enqueue((int)x * 10 + 1);
                }
            }
        }

        cnt++;
    }

    return -1;
}
