Console.ReadLine();
int b, r, o, n, z, e, s, i, l, v;
b = r = o = n = z = e = s = i = l = v = 0;
foreach (var item in Console.ReadLine()!.ToLower())
{
    switch (item)
    {
        case 'b':
            b++; break;
        case 'r':
            r++; break;
        case 'o':
            o++; break;
        case 'n':
            n++; break;
        case 'z':
            z++; break;
        case 'e':
            e++; break;
        case 's':
            s++; break;
        case 'i':
            i++; break;
        case 'l':
            l++; break;
        case 'v':
            v++; break;
        default:
            break;
    }
}

int a = 0;
while (b > 0 && r > 1 && o > 0 && n > 0 && z > 0 && e > 1 && s > 0 && i > 0 && l > 0 && v > 0)
{
    a++;

    b--; r -= 2; o--; n--; z--; e -= 2; s--; i--; l--; v--;
}
Console.WriteLine(a);