using static System.Console;

var n = int.Parse(ReadLine()!);

while (n-- > 0)
{
    ReadLine();
    var input = ReadLine()!.ToCharArray();
    Array.Sort(input);

    var b = int.Parse(input[0].ToString());

    Array.Reverse(input);
    var str = "";
    for (int i = 0; i < input.Length - 1; i++)
    {
        str += input[i];
    }

    var a = long.Parse(str);

    WriteLine(a + b);
}