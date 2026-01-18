string[] inputs = Console.ReadLine()!.Split();
int a = int.Parse(inputs[^1]);
int b = int.Parse(inputs[^2]);
Console.WriteLine($"{a-b}");
Console.WriteLine($"{a*b}");
Console.WriteLine($"{a+b+1}");