using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] input = sr.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(sr.ReadLine()!);
}

(int, int)[] tree = new (int, int)[2 << (int)Math.Ceiling(Math.Log2(n))];

Init(arr, tree, 1, 0, n - 1);

while (m-- > 0)
{
    input = sr.ReadLine()!.Split();
    int a = int.Parse(input[0]), b = int.Parse(input[1]);
    var (min, max) = Query(tree, 1, 0, n - 1, a - 1, b - 1);
    sw.WriteLine($"{min} {max}");
}

static void Init(int[] arr, (int min, int max)[] tree, int n, int start, int end)
{
    if (start == end)
    {
        tree[n] = (arr[start], arr[start]);
    }
    else
    {
        Init(arr, tree, n * 2, start, (start + end) / 2);
        Init(arr, tree, n * 2 + 1, (start + end) / 2 + 1, end);
        tree[n] = (Math.Min(tree[n * 2].min, tree[n * 2 + 1].min), Math.Max(tree[n * 2].max, tree[n * 2 + 1].max));
    }
}

static (int, int) Query((int, int)[] tree, int n, int start, int end, int left, int right)
{
    if (left > end || right < start)
    {
        return (int.MaxValue, int.MinValue);
    }
    if (left <= start && end <= right)
    {
        return tree[n];
    }

    var (min1, max1) = Query(tree, n * 2, start, (start + end) / 2, left, right);
    var (min2, max2) = Query(tree, n * 2 + 1, (start + end) / 2 + 1, end, left, right);

    return (Math.Min(min1, min2), Math.Max(max1, max2));
}
