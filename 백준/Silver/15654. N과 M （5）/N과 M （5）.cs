string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

bool[] b = new bool[n];
Array.Sort(a);
Array.Clear(b);
BackTracking(a, new int[m], b, n, 0, m);

static void BackTracking(int[] arr, int[] output, bool[] isSelected, int len, int m, int depth)
{
    if (m == depth)
    {
        Console.WriteLine(string.Join(' ', output));
    }
    else
    {
        for (int i = 0; i < len; i++)
        {
            if (isSelected[i])
            {
                continue;
            }

            output[m] = arr[i];
            isSelected[i] = true;
            BackTracking(arr, output, isSelected, len, m + 1, depth);
            isSelected[i] = false;
        }
    }
}
