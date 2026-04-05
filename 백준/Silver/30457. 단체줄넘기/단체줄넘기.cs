int n = int.Parse(Console.ReadLine()!);
string[] input = Console.ReadLine()!.Split();
int[] s = new int[1001];
for (int i = 0; i < n; i++)
{
    s[int.Parse(input[i])]++;
}

int r = 0;
foreach (int i in s)
{
    if (i > 0)
    {
        r++;
        if (i > 1)
        {
            r++;
        }
    }
}
Console.WriteLine(r);