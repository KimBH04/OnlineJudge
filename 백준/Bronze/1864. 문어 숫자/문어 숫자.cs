var octo = (char c) =>
{
    return c switch
    {
        '-' => 0,
        '\\' => 1,
        '(' => 2,
        '@' => 3,
        '?' => 4,
        '>' => 5,
        '&' => 6,
        '%' => 7,
        _ => -1,
    };
};

while (true)
{
    var input = Console.ReadLine()!;
    if (input == "#")
        break;

    var r = 0;
    var m = 1;
    foreach (var c in input.Reverse())
    {
        r += octo(c) * m;
        m *= 8;
    }

    Console.WriteLine(r);
}
