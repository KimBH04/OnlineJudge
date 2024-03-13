string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

Dictionary<string, string> dic = new(n);
while (n-- > 0)
{
    string[] songData = Console.ReadLine()!.Split();
    string eum = string.Join(' ', songData[2..5]);
    if (dic.ContainsKey(eum))
    {
        dic[eum] = "?";
    }
    else
    {
        dic.Add(eum, songData[1]);
    }
}

while (m-- > 0)
{
    string eum = Console.ReadLine()!;
    Console.WriteLine(dic.ContainsKey(eum) ? dic[eum] : "!");
}
