string[] input = Console.ReadLine()!.Split();
double w = double.Parse(input[0]);
double h = double.Parse(input[1]);

double r = Math.Round(w * h / 2, 1, MidpointRounding.ToNegativeInfinity);
Console.WriteLine($"{r:0.0}");