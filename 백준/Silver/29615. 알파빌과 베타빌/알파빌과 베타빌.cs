string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

inputs = Console.ReadLine()!.Split();
HashSet<int> friends = new();
foreach (string s in inputs)
{
    friends.Add(int.Parse(s));
}

int r = 0;
for (int i = 0; i < m; i++)
{
    if (!friends.Contains(a[i]))
    {
        r++;
    }
}

Console.WriteLine(r);