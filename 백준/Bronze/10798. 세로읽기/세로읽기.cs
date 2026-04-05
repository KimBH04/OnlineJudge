var arr = new char?[15, 5];

for (int i = 0; i < 5; i++)
{
    var input = Console.ReadLine()!.ToCharArray();
    for (int j = 0; j < input.Length; j++)
    {
        arr[j, i] = input[j];
    }
}

foreach (var chr in arr)
{
    if (chr != null)
    {
        Console.Write(chr);
    }
}