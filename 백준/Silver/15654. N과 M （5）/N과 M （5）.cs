using StreamWriter sw = new(Console.OpenStandardOutput());

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
BackTracking(sw, a, new int[m], b, n, 0, m);

static void BackTracking(StreamWriter sw, int[] arr, int[] output, bool[] isSelected, int len, int m, int depth)
{
    if (m == depth)
    {
        sw.WriteLine(string.Join(' ', output));
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
            BackTracking(sw, arr, output, isSelected, len, m + 1, depth);
            isSelected[i] = false;
        }
    }
}
