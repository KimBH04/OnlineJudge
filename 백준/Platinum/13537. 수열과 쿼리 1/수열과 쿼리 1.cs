using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int n = int.Parse(sr.ReadLine()!);
int[][] tree = new int[2 << (int)Math.Ceiling(Math.Log2(n))][];

int[] a = new int[n];
string[] input = sr.ReadLine()!.Split();
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(input[i]);
}

Init(a, tree, 1, 0, n - 1);

int m = int.Parse(sr.ReadLine()!);
while (m-- > 0)
{
    input = sr.ReadLine()!.Split();
    int i = int.Parse(input[0]),
        j = int.Parse(input[1]),
        k = int.Parse(input[2]);

    sw.WriteLine(Query(tree, 1, 0, n - 1, i - 1, j - 1, k));
}

static void Init(int[] a, int[][] tree, int n, int start, int end)
{
    if (start == end)
    {
        tree[n] = new int[1] { a[start] };
    }
    else
    {
        Init(a, tree, n * 2, start, (start + end) / 2);
        Init(a, tree, n * 2 + 1, (start + end) / 2 + 1, end);
        tree[n] = MergeSort(tree[n * 2], tree[n * 2 + 1]);
    }
}

static int Query(int[][] tree, int n, int start, int end, int left, int right, int k)
{
    if (left > end || right < start)
    {
        return 0;
    }

    if (left <= start && end <= right)
    {
        int len = tree[n].Length;
        int l = 0, r = len - 1;
        if (tree[n][l] > k)
        {
            return len;
        }
        else if (tree[n][r] <= k)
        {
            return 0;
        }

        while (l < r)
        {
            int m = (l + r) / 2;
            if (tree[n][m] > k)
            {
                r = m;
            }
            else if (m == l)
            {
                l++;
            }
            else
            {
                l = m;
            }
        }

        return len - l;
    }

    int ls = Query(tree, n * 2    , start                , (start + end) / 2, left, right, k);
    int rs = Query(tree, n * 2 + 1, (start + end) / 2 + 1, end              , left, right, k);
    return ls + rs;
}

static int[] MergeSort(int[] a, int[] b)
{
    int al = a.Length;
    int bl = b.Length;

    int[] merge = new int[al + bl];
    int i = 0;
    int j = 0;
    int k = 0;

    while (i < al && j < bl)
    {
        if (a[i] < b[j])
        {
            merge[k] = a[i];
            i++; k++;
        }
        else
        {
            merge[k] = b[j];
            j++; k++;
        }
    }

    while (i < al)
    {
        merge[k] = a[i];
        i++; k++;
    }

    while (j < bl)
    {
        merge[k] = b[j];
        j++; k++;
    }

    return merge;
}
