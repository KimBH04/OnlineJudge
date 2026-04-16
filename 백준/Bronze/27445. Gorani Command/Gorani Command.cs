var input = Console.ReadLine().Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
int[] v = new int[n], h = new int[m];

for (int i = 0; i < n - 1; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}
h = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
v[^1] = h[0];

var idxv = new int();
var minv = int.MaxValue;
for (int i = 0; i < n; i++)
{
    if (minv > v[i])
    {
        minv = v[i];
        idxv = i + 1;
    }
}

var idxh = new int();
var minh = int.MaxValue;
for (int i = 0; i < m; i++)
{
    if (minh > h[i])
    {
        minh = h[i];
        idxh = i + 1;
    }
}

Console.WriteLine(idxv + " " + idxh);