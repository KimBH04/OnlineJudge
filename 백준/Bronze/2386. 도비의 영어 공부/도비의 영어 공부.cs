while (true)
{
    var input = Console.ReadLine()!.ToLower();
    if (input == "#")
        break;

    var alpha = input[0];
    var r = 0;
    foreach (var c in input[2..])
    {
        if (alpha == c)
        {
            r++;
        }
    }

    Console.WriteLine(alpha + " " + r);
}
