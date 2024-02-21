int n = int.Parse(Console.ReadLine()!);
var scoreboard = () =>
{
    return n switch
    {
        1 => (12, 1600),
        2 => (11, 894),
        3 => (11, 1327),
        4 => (10, 1311),
        5 => (9, 1004),
        6 => (9, 1178),
        7 => (9, 1357),
        8 => (8, 837),
        9 => (7, 1055),
        10 => (6, 556),
        11 => (6, 773),
        _ => (-1, -1)
    };
};

var (a, b) = scoreboard();
Console.WriteLine($"{a} {b}");