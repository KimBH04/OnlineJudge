const string B = "ABCDEFGHIJKLMNOPQRSTUVWXYZ", S = "abcdefghijklmnopqrstuvwxyz1234567890";

string[] input = Console.ReadLine()!.Split();
int j = int.Parse(input[0]), n = int.Parse(input[1]);
int r = 0;
while (n-- > 0)
{
    int s = 0;
    foreach (char c in Console.ReadLine()!)
    {
        if (B.Contains(c))
        {
            s += 4;
        }
        else if (S.Contains(c))
        {
            s += 2;
        }
        else
        {
            s++;
        }
    }
    if (s <= j)
    {
        r++;
    }
}
Console.WriteLine(r);