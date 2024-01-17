using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

bool[] eratos = new bool[1000000];
for (int i = 0; i < 1000000; i++)
{
    eratos[i] = true;
}

eratos[0] = eratos[1] = false;
for (int i = 2; i < 1000000; i++)
{
    if (eratos[i])
    {
        for (int j = i + i; j < 1000000; j += i)
        {
            eratos[j] = false;
        }
    }
}

while (true)
{
    int n = int.Parse(sr.ReadLine()!);
    if (n == 0)
    {
        break;
    }

    for (int i = 3; i <= n - i; i += 2)
    {
        if (eratos[i] && eratos[n - i])
        {
            sw.WriteLine($"{n} = {i} + {n - i}");
            goto Goldbach;
        }
    }
    sw.WriteLine("Goldbach's conjecture is wrong.");
Goldbach:;
}
