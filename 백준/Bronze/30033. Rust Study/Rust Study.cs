int n = int.Parse(Console.ReadLine()!);

string[] input = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(input[i]);
}

input = Console.ReadLine()!.Split();
int r = 0;
while (n-- > 0)
{
    if (a[n] <= int.Parse(input[n]))
    {
        r++;
    }
}

Console.WriteLine(r);