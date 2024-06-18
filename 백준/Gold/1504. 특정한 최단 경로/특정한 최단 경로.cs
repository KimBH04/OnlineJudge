using CT = KimBH.ConsoleTokenizer;
const long INF = int.MaxValue;
Func<int> getInt32 = () => int.Parse(CT.Next());

int n = getInt32(), e = getInt32();
List<(int, long)>[] edges = new List<(int, long)>[n + 1];
for (int i = 0; i <= n; i++)
{
    edges[i] = new();
}

while (e-- > 0)
{
    int a = getInt32(),
        b = getInt32(),
        c = getInt32();

    edges[a].Add((b, c));
    edges[b].Add((a, c));
}

int v1 = getInt32(), v2 = getInt32();
long mid = Dijkstra(edges, v1, v2);
long a2mid1 = Dijkstra(edges, 1, v1);
long a2mid2 = Dijkstra(edges, 1, v2);
long mid2b1 = Dijkstra(edges, v1, n);
long mid2b2 = Dijkstra(edges, v2, n);
if (mid == INF || (a2mid1 == INF && a2mid2 == INF) || (mid2b1 == INF && mid2b2 == INF))
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine(Math.Min(a2mid1 + mid + mid2b2, a2mid2 + mid + mid2b1));
}

static long Dijkstra(List<(int, long)>[] edges, int a, int b)
{
    long[] weights = Enumerable.Repeat(INF, edges.Length).ToArray();
    weights[a] = 0;

    PriorityQueue<int, long> pq = new();
    pq.Enqueue(a, 0);

    while (pq.TryDequeue(out int node, out long weight))
    {
        if (weights[node] < weight)
        {
            continue;
        }

        foreach (var (n, w) in edges[node])
        {
            if (weights[n] > weight + w)
            {
                pq.Enqueue(n, weights[n] = weight + w);
            }
        }
    }
    return weights[b];
}

namespace KimBH
{
    public static class ConsoleTokenizer
    {
        private static int index = 0;
        private static List<string> tokenizer = new();

        static ConsoleTokenizer()
        {
            using StreamReader sr = new(Console.OpenStandardInput());
            string[] lines = sr.ReadToEnd().Split('\n');
            foreach (string line in lines)
            {
                tokenizer.AddRange(line.Trim().Split());
            }
        }

        public static string Next()
        {
            if (tokenizer.Count > index)
            {
                return tokenizer[index++];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}