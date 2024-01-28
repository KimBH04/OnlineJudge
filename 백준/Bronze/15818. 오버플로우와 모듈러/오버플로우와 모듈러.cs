string[] inputs = Console.ReadLine()!.Split();
int m = int.Parse(inputs[1]);

long multi = 1;
foreach (string i in Console.ReadLine()!.Split())
{
    multi = multi % m * (int.Parse(i) % m) % m;
}

Console.WriteLine(multi);