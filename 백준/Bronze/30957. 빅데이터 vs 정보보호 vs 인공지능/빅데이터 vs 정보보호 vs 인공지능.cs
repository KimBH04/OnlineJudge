int n = int.Parse(Console.ReadLine()!);
string q = Console.ReadLine()!;

Dictionary<char, int> dic = new() { { 'B', 0 }, { 'S', 0 }, { 'A', 0 } };
for (int i = 0; i < n; i++)
{
    dic[q[i]]++;
}

if (dic['B'] == dic['S'] && dic['S'] == dic['A'])
{
    Console.WriteLine("SCU");
}
else
{
    int max = 0;
    foreach (int item in dic.Values)
    {
        if (max < item)
        {
            max = item;
        }
    }

    foreach (var kv in dic)
    {
        if (max == kv.Value)
        {
            Console.Write(kv.Key);
        }
    }
}
