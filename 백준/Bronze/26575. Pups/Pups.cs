int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    double d = double.Parse(inputs[0]),
           f = double.Parse(inputs[1]),
           p = double.Parse(inputs[2]);
    Console.WriteLine($"${d * f * p:F2}");
}
