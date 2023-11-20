using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(sr.ReadLine()!);
}

int[] tree = new int[2 << (int)Math.Ceiling(Math.Log2(n))];
Init(arr, tree, 1, 0, n - 1);

while (m-- > 0)
{
    inputs = sr.ReadLine()!.Split();
    int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]);

    sw.WriteLine(Query(tree, 1, 0, n - 1, a - 1, b - 1));
}

static void Init(int[] arr, int[] tree, int n, int start, int end)
{
    if (start == end)
    {
        tree[n] = arr[start];
    }
    else
    {
        Init(arr, tree, n * 2, start, (start + end) / 2);
        Init(arr, tree, n * 2 + 1, (start + end) / 2 + 1, end);
        tree[n] = tree[n * 2] < tree[n * 2 + 1] ? tree[n * 2] : tree[n * 2 + 1];
    }
}

static int Query(int[] tree, int n, int start, int end, int left, int right)
{
    if (left > end || right < start)
    {
        return int.MaxValue;
    }
    if (left <= start && end <= right)
    {
        return tree[n];
    }
    int l = Query(tree, n * 2, start, (start + end) / 2, left, right);
    int r = Query(tree, n * 2 + 1, (start + end) / 2 + 1, end, left, right);
    return l < r ? l : r;
}
