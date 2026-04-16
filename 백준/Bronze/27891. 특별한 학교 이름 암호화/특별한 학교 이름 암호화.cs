var amho = "abcdefghijklmnopqrstuvwxyz";
var input = Console.ReadLine()!;

for (int i = 0; i < 26; i++)
{
    var haedok = string.Empty;

    foreach (char c in input)
    {
        haedok += amho[c - 97];
    }

    if (haedok == "northlondo")
    {
        Console.WriteLine("NLCS");
        break;
    }
    if (haedok == "branksomeh")
    {
        Console.WriteLine("BHA");
        break;
    }
    if (haedok == "koreainter")
    {
        Console.WriteLine("KIS");
        break;
    }
    if (haedok == "stjohnsbur")
    {
        Console.WriteLine("SJA");
        break;
    }

    amho = amho[1..] + amho[0];
}
