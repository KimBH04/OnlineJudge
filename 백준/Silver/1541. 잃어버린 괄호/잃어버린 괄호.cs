var input = Console.ReadLine();
var num = new List<int>();
var opt = new List<char>() { '+' };

var strNum = "";
foreach (char c in input)
{
    if (c == '+' || c == '-')
    {
        num.Add(int.Parse(strNum));
        strNum = "";

        opt.Add(c);
    }
    else
    {
        strNum += c;
    }
}
num.Add(int.Parse(strNum));

var r = 0;
var minus = 0;
for (int i = 0; i < num.Count; i++)
{
    if (opt[i] == '-')
    {
        minus = num.ToArray()[i..].Sum();
        break;
    }
    else
    {
        r += num[i];
    }
}

Console.WriteLine(r - minus);