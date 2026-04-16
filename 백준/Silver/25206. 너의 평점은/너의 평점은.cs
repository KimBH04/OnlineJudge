double hak = 0, jeon = 0;
var Gwa = (string gwa) =>
{
    return gwa switch
    {
        "A+" => 4.5,
        "A0" => 4.0,
        "B+" => 3.5,
        "B0" => 3.0,
        "C+" => 2.5,
        "C0" => 2.0,
        "D+" => 1.5,
        "D0" => 1.0,
        _ => 0.0,
    };
};

for (int i = 0; i < 20; i++)
{
    var input = Console.ReadLine()!.Split();
    if (input[2] == "P")
        continue;

    var d = double.Parse(input[1]);
    hak += d;
    jeon += d * Gwa(input[2]);
}

Console.WriteLine(jeon / hak);