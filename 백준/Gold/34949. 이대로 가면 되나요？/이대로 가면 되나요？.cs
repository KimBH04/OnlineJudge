int n = int.Parse(Console.ReadLine()!);
var map = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

int[] result = new int[n + 1];
List<int>[] edges = new List<int>[n + 1];
for (int i = 1; i <= n; i++)
{
    result[i] = -1;
    edges[i] = new();
}

for (int i = 0; i < n; i++)
{
    edges[map[i]].Add(i + 1);
}

result[n] = 0;
int cnt = 1;
Queue<int> q = new();
q.Enqueue(n);
while (q.Count > 0)
{
    int qCnt = q.Count;
    while (qCnt-- > 0)
    {
        int e = q.Dequeue();
        foreach (int v in edges[e])
        {
            if (result[v] != -1)
            {
                continue;
            }

            result[v] = cnt;
            q.Enqueue(v);
        }
    }

    cnt++;
}

using var sw = new StreamWriter(Console.OpenStandardOutput());
for (int i = 1; i <= n; i++)
{
    sw.Write($"{result[i]} ");
}