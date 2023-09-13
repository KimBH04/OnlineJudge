var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
var baguni = Enumerable.Range(1, n).ToArray();

for (int a = 0; a < m; a++)
{
    input = Console.ReadLine()!.Split();
    int i = int.Parse(input[0]), j = int.Parse(input[1]);

    var bag = baguni[(i - 1)..j];
    Array.Reverse(bag);

    for (int b = i - 1; b < j; b++)
    {
        baguni[b] = bag[b - i + 1];
    }
}

foreach (var item in baguni)
{
    Console.Write(item + " ");
}