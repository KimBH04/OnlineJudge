int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(inputs[i]);
}

int[] indexes = new int[n];
List<int> lis = new(n) { arr[0] };
for (int i = 1; i < n; i++)
{
    if (lis[^1] < arr[i])
    {
        lis.Add(arr[i]);
        indexes[i] = lis.Count - 1;
    }
    else
    {
        int left = 0, right = lis.Count - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (lis[mid] < arr[i])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        lis[left] = arr[i];
        indexes[i] = left;
    }
}

Stack<int> stack = new(lis.Count);
for (int i = n - 1, c = lis.Count - 1; i > -1; i--)
{
    if (indexes[i] == c)
    {
        stack.Push(arr[i]);
        c--;
    }
}

Console.WriteLine(lis.Count);
Console.WriteLine(string.Join(' ', stack));