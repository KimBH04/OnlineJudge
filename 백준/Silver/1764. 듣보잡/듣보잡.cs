var dic = new Dictionary<string, bool>();
var ls = new List<string>();

var sw = new StringWriter();

var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
for (int i = 0; i < input[0]; i++)
{
    var s = Console.ReadLine();
    dic.Add(s, true);
}

var r = 0;
for (int i = 0; i < input[1]; i++)
{
    var s = Console.ReadLine();
    if (dic.ContainsKey(s))
    {
        ls.Add(s);
        r++;
    }
}

ls.Sort();

foreach (var s in ls) sw.WriteLine(s);

Console.WriteLine(r);
Console.Write(sw);