string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]),
    k = int.Parse(input[2]);

long[] arr = new long[n];
for (int i = 0; i < n; i++)
{
    arr[i] = long.Parse(Console.ReadLine()!);
}

int h = (int)Math.Ceiling(Math.Log2(n));
long[] tree = new long[1 << (h + 1)];
Init(arr, tree, 1, 0, n - 1);

for (int i = 0; i < m + k; i++)
{
    input = Console.ReadLine()!.Split();
    int a = int.Parse(input[0]);

    if (a == 1)
    {
        int b = int.Parse(input[1]);
        long c = long.Parse(input[2]);
        Update(arr, tree, 1, 0, n - 1, b - 1, c);
    }
    else
    {
        int b = int.Parse(input[1]),
            c = int.Parse(input[2]);
        Console.WriteLine(Sum(tree, 1, 0, n - 1, b - 1, c - 1));
    }
}

static void Init(long[] a, long[] tree, int node, int start, int end)
{
    if (start == end)
    {
        tree[node] = a[start];
    }
    else
    {
        Init(a, tree, node * 2, start, (start + end) / 2);
        Init(a, tree, node * 2 + 1, (start + end) / 2 + 1, end);
        tree[node] = tree[node * 2] + tree[node * 2 + 1];
    }
}

static long Sum(long[] tree, int node, int start, int end, int left, int right)
{
    if (left > end || right < start)
    {
        return 0;
    }
    if (left <= start && end <= right)
    {
        return tree[node];
    }

    long l = Sum(tree, node * 2, start, (start + end) / 2, left, right);
    long r = Sum(tree, node * 2 + 1, (start + end) / 2 + 1, end, left, right);
    return l + r;
}

static void Update(long[] a, long[] tree, int node, int start, int end, int index, long val)
{
    if (index < start || index > end)
    {
        return;
    }

    if (start == end)
    {
        a[index] = val;
        tree[node] = val;
        return;
    }

    Update(a, tree, node * 2, start, (start + end) / 2, index, val);
    Update(a, tree, node * 2 + 1, (start + end) / 2 + 1, end, index, val);
    tree[node] = tree[node * 2] + tree[node * 2 + 1];
}
