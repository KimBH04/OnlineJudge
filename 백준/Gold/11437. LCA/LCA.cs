int n = int.Parse(Console.ReadLine()!) + 1;
List<int>[] tree = new List<int>[n];
for (int i = 0; i < n; i++)
{
    tree[i] = new();
}

for (int i = 2; i < n; i++)
{
    string[] inputs = Console.ReadLine()!.Split();
    int a = int.Parse(inputs[0]),
        b = int.Parse(inputs[1]);
    tree[a].Add(b);
    tree[b].Add(a);
}

int[] parents = new int[n];
int[] depth = new int[n];
parents[1] = -1;
Queue<int> queue = new();
queue.Enqueue(1);
while (queue.Count > 0)
{
    int e = queue.Dequeue();
    foreach (var item in tree[e])
    {
        if (parents[item] != 0)
        {
            continue;
        }

        parents[item] = e;
        depth[item] = depth[e] + 1;
        queue.Enqueue(item);
    }
}

int m = int.Parse(Console.ReadLine()!);
while (m-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int a = int.Parse(inputs[0]),
        b = int.Parse(inputs[1]);

    while (depth[a] > depth[b])
    {
        a = parents[a];
    }
    while (depth[a] < depth[b])
    {
        b = parents[b];
    }

    while (a != b)
    {
        a = parents[a];
        b = parents[b];
    }

    Console.WriteLine(a);
}
