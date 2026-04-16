string[] inputs = Console.ReadLine()!.Split();
int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]);
double m = (b - a) / 400d;

Console.WriteLine(1 / (1 + Math.Pow(10, m)));