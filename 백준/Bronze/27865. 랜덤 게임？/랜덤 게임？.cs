using static System.Console;
int n = int.Parse(ReadLine()!);
n++;
n /= 2;
while (true)
{
    WriteLine($"? {n}");
    if (ReadLine()! == "Y")
    {
        WriteLine($"! {n}");
        break;
    }
}
