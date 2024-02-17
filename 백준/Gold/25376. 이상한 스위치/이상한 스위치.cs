int n = int.Parse(Console.ReadLine()!);
int bit = 0;

string[] inputs = Console.ReadLine()!.Split();
foreach (string input in inputs)
{
    bit <<= 1;
    bit |= int.Parse(input);
}

int[] bitMask = new int[n];
for (int i = 0; i < n; i++)
{
    bitMask[i] = 1 << (n - (i + 1));

    string[] info = Console.ReadLine()!.Split();
    int m = int.Parse(info[0]);
    for (int j = 1; j <= m; j++)
    {
        int c = int.Parse(info[j]);
        bitMask[i] |= 1 << (n - c);
    }
}

bool[] visited = new bool[1 << n];
visited[bit] = true;

Queue<int> queue = new();
queue.Enqueue(bit);

int cnt = 0;
int target = (1 << n) - 1;
while (queue.Count > 0)
{
    int qCnt = queue.Count;
    while (qCnt-- > 0)
    {
        int e = queue.Dequeue();
        if (e == target)
        {
            Console.WriteLine(cnt);
            return;
        }

        for (int i = 0; i < n; i++)
        {
            int v = e ^ bitMask[i];
            if ((e & (1 << (n - (i + 1)))) == 0 && !visited[v])
            {
                visited[v] = true;
                queue.Enqueue(v);
            }
        }
    }
    cnt++;
}

Console.WriteLine(-1);
