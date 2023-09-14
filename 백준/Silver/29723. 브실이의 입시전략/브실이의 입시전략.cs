string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]), k = int.Parse(input[2]);
Dictionary<string, int> dic = new();

m -= k;
int c = 0;
while (n-- > 0)
{
    input = Console.ReadLine()!.Split();
    dic.Add(input[0], int.Parse(input[1]));
}

while (k-- > 0)
{
    string s = Console.ReadLine()!;
    c += dic[s];
    dic.Remove(s);
}

int[] a = dic.Values.ToArray();
Array.Sort(a);
Console.WriteLine($"{c + a[..m].Sum()} {c + a[(a.Length - m)..].Sum()}");