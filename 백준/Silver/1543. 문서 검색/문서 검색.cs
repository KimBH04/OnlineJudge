string name = Console.ReadLine()!;
string search = Console.ReadLine()!;

int searchLen = search.Length;
int diff = name.Length - searchLen;

int cnt = 0;
int idx = 0;
while (idx <= diff)
{
    if (name[idx..(idx + searchLen)] == search)
    {
        cnt++;
        idx += searchLen;
    }
    else
    {
        idx++;
    }
}

Console.WriteLine(cnt);
