if (Console.ReadLine()! == "1")
{
    string[] inputs = Console.ReadLine()!.Split();
    long a = long.Parse(inputs[0]),
        b = long.Parse(inputs[1]);

    long c = a + b;
    char[] result = new char[13];
    for (int i = 12; i >= 0; i--)
    {
        result[i] = (char)(c % 26 + 'a');
        c /= 26;
    }
    Console.WriteLine(string.Join(string.Empty, result));
}
else
{
    string input = Console.ReadLine()!;
    long result = 0;
    foreach (char c in input)
    {
        result *= 26;
        result += c - 'a';
    }
    Console.WriteLine(result);
}
