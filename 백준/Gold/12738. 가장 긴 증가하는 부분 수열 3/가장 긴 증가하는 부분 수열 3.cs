int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

List<long> lis = new() { long.Parse(inputs[0]) };
for (int i = 1; i < n; i++)
{
    long a = long.Parse(inputs[i]);

    if (lis[^1] < a)
    {
        lis.Add(a);
    }
    else
    {
        int left = 0, right = lis.Count - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (lis[mid] < a)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        lis[left] = a;
    }
}

Console.WriteLine(lis.Count);