static void MergeSort(int[] a, int start, int end, List<int> saved)
{
    int mid = (start + end) / 2;
    mid = start + end - mid;
    if (start == mid || end == mid)
    {
        return;
    }

    MergeSort(a, start, mid, saved);
    MergeSort(a, mid, end, saved);
    Merge(a, start, mid, end, saved);
}

static void Merge(int[] a, int start, int mid, int end, List<int> saved)
{
    int[] tmp = new int[end - start];
    int t = 0;

    int i = start, j = mid;
    while (i < mid && j < end)
    {
        if (a[i] < a[j])
        {
            tmp[t++] = a[i++];
        }
        else
        {
            tmp[t++] = a[j++];
        }
    }

    while (i < mid)
    {
        tmp[t++] = a[i++];
    }

    while (j < end)
    {
        tmp[t++] = a[j++];
    }

    for (i = start; i < end; i++)
    {
        a[i] = tmp[i - start];
        saved.Add(a[i]);
    }
}

string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

List<int> saved = new();
MergeSort(a, 0, n, saved);

Console.WriteLine(saved.Count > k ? saved[k - 1] : -1);