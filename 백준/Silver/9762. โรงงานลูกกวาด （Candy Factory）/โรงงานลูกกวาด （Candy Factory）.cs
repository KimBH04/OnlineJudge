using static System.Console;

var t = int.Parse(ReadLine());

while (t-- > 0)
{
    int helux = 0;
    var n = int.Parse(ReadLine());
    var candy = Enumerable.Repeat(-1, n + 1).ToArray();
    var c = ReadLine().Split();

    for (int j = n / 2; j < n; j++)
    {
        candy[j + 1] = int.Parse(c[j - n / 2]);
    }

    WriteLine(Sudyxdlukkwad(candy, 1, ref helux) + helux);
}

static int Sudyxdlukkwad(int[] arr, int n, ref int helux)
{
    if (arr[n] == -1)
    {
        int l = Sudyxdlukkwad(arr, n * 2, ref helux), r = Sudyxdlukkwad(arr, n * 2 + 1, ref helux);
        arr[n] = Math.Min(l, r);
        helux += Math.Abs(l - r);
    }

    return arr[n];
}
