int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int aa = 0,
    bb = 0;

string r = "D";
for (int i = 0; i < 10; i++)
{
    if (a[i] > b[i])
    {
        aa += 3;
        r = "A";
    }
    else if (a[i] < b[i])
    {
        bb += 3;
        r = "B";
    }
    else
    {
        aa++;
        bb++;
    }
}

Console.WriteLine($"{aa} {bb}\n{(aa > bb ? "A" : aa < bb ? "B" : r)}");