var I = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int n = I[0], s = I[1];
var N = new int[n + 1];
var a = Console.ReadLine().Split();

N[0] = 0;
for (var i = 1; i <= n; i++)
{
    N[i] = N[i - 1] + int.Parse(a[i - 1]);
}

if (N[^1] >= s)
{
    int l = 0, r = 1, len = int.MaxValue;
    while (r <= n)
    {
        if (N[r] - N[l] >= s)
        {
            len = Math.Min(len, r - l);
            l++;
        }
        else r++;
    }

    Console.WriteLine(len);
}
else Console.WriteLine(0);