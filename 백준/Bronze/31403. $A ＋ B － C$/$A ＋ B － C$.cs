using static System.Console;

string a = ReadLine()!;
string b = ReadLine()!;
int c = int.Parse(ReadLine()!);

WriteLine(int.Parse(a) + int.Parse(b) - c);
WriteLine(int.Parse(a + b) - c);