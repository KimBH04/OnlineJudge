string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), l = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] arr = new int[n];
while (n-- > 0)
{
    arr[n] = int.Parse(inputs[n]);
}
Array.Sort(arr);

foreach (int i in arr)
{
    if (l < i)
    {
        break;
    }
    else
    {
        l++;
    }
}

Console.WriteLine(l);