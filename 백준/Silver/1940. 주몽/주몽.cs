int n = int.Parse(Console.ReadLine()!);
int m = int.Parse(Console.ReadLine()!);

string[] input = Console.ReadLine()!.Split();
int[] mats = new int[n];

for (int i = 0; i < n; i++)
{
    mats[i] = int.Parse(input[i]);
}

Array.Sort(mats);

int r = 0;
int left = 0, right = n - 1;

while (left < right)
{
    if (mats[left] + mats[right] < m)
    {
        left++;
    }
    else if (mats[left] + mats[right] > m)
    {
        right--;
    }
    else
    {
        r++;
        left++;
        right--;
    }
}

Console.WriteLine(r);