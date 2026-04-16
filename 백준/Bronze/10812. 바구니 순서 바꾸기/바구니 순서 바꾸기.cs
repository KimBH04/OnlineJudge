var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), 
    m = int.Parse(input[1]);

var baguni = new List<int>();
for (int i = 0; i <= n; i++)
{
    baguni.Add(i);
}

while (m-- > 0)
{
    input = Console.ReadLine()!.Split();
    int i = int.Parse(input[0]),
        j = int.Parse(input[1]),
        k = int.Parse(input[2]);

    int mid = baguni[k];

    while (baguni[i] != mid)
    {
        baguni.Insert(i, baguni[j]);
        baguni.RemoveAt(j + 1);
    }
}

baguni.RemoveAt(0);
Console.WriteLine(string.Join(' ', baguni));