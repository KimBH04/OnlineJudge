int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();

int[] arr = new int[100001];
foreach (string input in inputs)
{
    arr[int.Parse(input)]++;
}

int max = 0;
foreach (int a in arr)
{
    max = a > max ? a : max;
}

Console.WriteLine(n - n / 2 < max ? "NO" : "YES");