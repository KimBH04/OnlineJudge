string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]), k = int.Parse(input[2]);
Console.WriteLine($"{Math.Max(n - m * k, 0)} {Math.Max(n - m * k + m - 1, 0)}");