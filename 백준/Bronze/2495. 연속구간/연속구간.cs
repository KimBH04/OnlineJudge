int i = 3;
while (i-- > 0)
{
    string s = Console.ReadLine()!;
    int r = 1, c = 1;
    char a = '\0';
    foreach (char item in s)
    {
        if (item == a)
        {
            c++;
        }
        else
        {
            a = item;
            r = Math.Max(r, c);
            c = 1;
        }
    }
    Console.WriteLine(Math.Max(r, c));
}