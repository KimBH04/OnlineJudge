string[] inputs = Console.ReadLine()!.Split();
int s = int.Parse(inputs[0]), k = int.Parse(inputs[1]), h = int.Parse(inputs[2]);

if (s + k + h > 99)
{
    Console.WriteLine("OK");
}
else
{
    if (s < k && s < h)
    {
        Console.WriteLine("Soongsil");
    }
    else if (k < s && k < h)
    {
        Console.WriteLine("Korea");
    }
    else if (h < s && h < k)
    {
        Console.WriteLine("Hanyang");
    }
}
