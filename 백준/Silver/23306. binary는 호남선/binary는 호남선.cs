using static System.Console;
int n = int.Parse(ReadLine()!);

WriteLine("? 1");
int f = int.Parse(ReadLine()!);

WriteLine($"? {n}");
int e = int.Parse(ReadLine()!);

WriteLine(f > e ? "! -1" : f < e ? "! 1" : "! 0");