string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]),
    k = int.Parse(input[2]);

string[] s = new string[n];
while (n-- > 0)
{
    s[n] = string.Join("", Console.ReadLine()!.OrderBy(x => x));
}

Array.Sort(s);
Console.WriteLine(string.Join("", string.Join("", s[..k]).OrderBy(x => x)));