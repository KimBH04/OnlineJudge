using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
string[] inputs = sr.ReadLine()!.Split();

int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

(int, int)[] t = new (int, int)[2 << (int)Math.Ceiling(Math.Log2(n))];

Init(a, t, 1, 0, n - 1);

int m = int.Parse(sr.ReadLine()!);
while (m-- > 0)
{
    string[] query = sr.ReadLine()!.Split();
    int command = int.Parse(query[0]);
    if (command == 1)
    {
        int i = int.Parse(query[1]), x = int.Parse(query[2]);
        Update(a, t, 1, 0, n - 1, i - 1, x);
    }
    else
    {
        int l = int.Parse(query[1]), r= int.Parse(query[2]);
        var (even, odd) = Query(t, 1, 0, n - 1, l - 1, r - 1);
        if (command % 2 == 0)
        {
            sw.WriteLine(even);
        }
        else
        {
            sw.WriteLine(odd);
        }
    }
}

static void Init(int[] arr, (int, int)[] tree, int node, int start, int end)
{
    if (start == end)
    {
        tree[node] = arr[start] % 2 == 0 ? (1, 0) : (0, 1); 
    }
    else
    {
        Init(arr, tree, node * 2, start, (start + end) / 2);
        Init(arr, tree, node * 2 + 1, (start + end) / 2 + 1, end);
        tree[node] = AddTuple(tree[node * 2], tree[node * 2 + 1]);
    }
}

static void Update(int[] arr, (int, int)[] tree, int node, int start, int end, int index, int value)
{
    if (index < start || index > end)
        return;

    if (start == end)
    {
        arr[index] = value;
        tree[node] = value % 2 == 0 ? (1, 0) : (0, 1);
    }
    else
    {
        Update(arr, tree, node * 2, start, (start + end) / 2, index, value);
        Update(arr, tree, node * 2 + 1, (start + end) / 2 + 1, end, index, value);
        tree[node] = AddTuple(tree[node * 2], tree[node * 2 + 1]);
    }
}

static (int, int) Query((int, int)[] tree, int node, int start, int end, int left, int right)
{
    if (left > end || right < start)
    {
        return (0, 0);
    }
    if (left <= start && end <= right)
    {
        return tree[node];
    }

    (int, int) l = Query(tree, node * 2, start, (start + end) / 2, left, right);
    (int, int) r = Query(tree, node * 2 + 1, (start + end) / 2 + 1, end, left, right);
    return AddTuple(l, r);
}

static (int, int) AddTuple((int, int) a, (int , int) b)
{
    return (a.Item1 + b.Item1, a.Item2 + b.Item2);
}