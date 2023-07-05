for (int i = 1; ; i++)
{
    string[] input = Console.ReadLine()!.Split();
    if (input[1] == "E")
        break;

    int a = int.Parse(input[0]),
        b = int.Parse(input[2]);

    Console.WriteLine($"Case {i}: {(Sik(a, b, input[1]) + "").ToLower()}");
}

static bool Sik(int a, int b, string sik)
{
    return sik switch
    {
        ">" => a > b,
        ">=" => a >= b,
        "<" => a < b,
        "<=" => a <= b,
        "==" => a == b,
        "!=" => a != b,
        _ => false,
    };
}
