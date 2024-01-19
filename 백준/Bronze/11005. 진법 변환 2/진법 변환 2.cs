var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), b = int.Parse(input[1]);

var r = "";
while (n > 0)
{
    var m = n % b;
    r += m > 9 ? (char)(m + 55) : m.ToString();

    n /= b;
}
foreach (var m in r.Reverse())
{
    Console.Write(m);
}