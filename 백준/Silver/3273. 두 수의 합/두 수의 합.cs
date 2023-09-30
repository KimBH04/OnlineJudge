int n = int.Parse(Console.ReadLine()!);

int[] a = new int[n];
string[] input = Console.ReadLine()!.Split();
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(input[i]);
}
Array.Sort(a);

int x = int.Parse(Console.ReadLine()!);

int left = 0, right = n - 1;
int r = 0;
while (left < right)
{
    if (a[left] + a[right] > x)
    {
        right--;
    }
    else if (a[left] + a[right] < x)
    {
        left++;
    }
    else
    {
        r++;
        left++;
        right--;
    }
}

Console.WriteLine(r);