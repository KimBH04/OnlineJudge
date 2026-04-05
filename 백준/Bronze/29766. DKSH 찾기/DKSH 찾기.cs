string s = Console.ReadLine()!;
int r = 0;
for (int i = 0; i < s.Length - 3; i++)
{
    if (s[i..(i + 4)] == "DKSH")
        r++;
}

Console.WriteLine(r);