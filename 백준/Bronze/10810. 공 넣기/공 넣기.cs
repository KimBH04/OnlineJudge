var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);
var arr = new int[n];
Array.Clear(arr, 0, n);

for (int a = 0; a < m; a++)
{
    input = Console.ReadLine()!.Split();
    int i = int.Parse(input[0]), 
        j = int.Parse(input[1]),
        k = int.Parse(input[2]);

    for (int b = i - 1; b < j; b++)
    {
        arr[b] = k;
    }
}

foreach (int c in arr)
{
    Console.Write(c + " ");
}