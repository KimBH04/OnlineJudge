string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]), r = int.Parse(inputs[2]);

inputs = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

inputs = Console.ReadLine()!.Split();
int[] b = new int[m];
for (int i = 0; i < m; i++)
{
    b[i] = int.Parse(inputs[i]);
}
Array.Sort(b);

double max = -1;
for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        int bottom = Math.Abs(a[i] - a[j]);
        double area;
        int left = 0, right = m - 1;

        if (bottom * b[left] > r + r)
        {
            continue;
        }
        else if (bottom * b[right] <= r + r)
        {
            area = bottom * b[right] / 2d;
            max = max > area ? max : area;
            continue;
        }

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (bottom * b[mid] > r + r)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        area = bottom * b[left - 1] / 2d;
        max = max > area ? max : area;
    }
}

Console.WriteLine(max < 0 ? -1 : $"{max:0.0}");