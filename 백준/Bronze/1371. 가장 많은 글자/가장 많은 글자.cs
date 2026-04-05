var alpha = new int[26];

using (StreamReader sr = new(Console.OpenStandardInput()))
{
    while (!sr.EndOfStream)
    {
        var arr = sr.ReadLine()!;

        foreach (var item in arr)
        {
            if (item.Equals(' '))
                continue;

            alpha[item - 97]++;
        }
    }
}

var max = 0;
foreach (var item in alpha)
{
    if (max < item)
        max = item;
}

for (var i = 0; i < 26; i++)
{
    if (alpha[i] == max)
        Console.Write((char)(i + 97));
}
