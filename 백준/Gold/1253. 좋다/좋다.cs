int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}
Array.Sort(a);

int r = 0;
for (int i = 0; i < n; i++)
{
    int left = 0, right = n - 1;
    while (left < right)
    {
        if (left == i)
        {
            left++;
        }
        else if (right == i)
        {
            right--;
        }

        if (left >= right)
        {
            break;
        }

        int sum = a[left] + a[right];
        if (sum < a[i])
        {
            left++;
        }
        else if (sum > a[i])
        {
            right--;
        }
        else
        {
            r++;
            break;
        }
    }
}

Console.WriteLine(r);