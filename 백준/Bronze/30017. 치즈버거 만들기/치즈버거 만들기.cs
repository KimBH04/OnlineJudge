string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]), b = int.Parse(input[1]);
Console.WriteLine(a > b ? b + b + 1 : a + a - 1);