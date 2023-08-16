using static System.Console;
int a = int.Parse(ReadLine()!), b = int.Parse(ReadLine()!), c = int.Parse(ReadLine()!), d = int.Parse(ReadLine()!), e = int.Parse(ReadLine()!);
WriteLine(a < 0 ? -a * c + b * e + d : (b - a) * e);