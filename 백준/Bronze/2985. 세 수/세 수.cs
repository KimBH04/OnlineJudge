string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]),
    b = int.Parse(input[1]),
    c = int.Parse(input[2]);

Console.WriteLine(a + b == c ? $"{a}+{b}={c}" : a - b == c ? $"{a}-{b}={c}" : a * b == c ? $"{a}*{b}={c}" : a / b == c ? $"{a}/{b}={c}" : a == b + c ? $"{a}={b}+{c}" : a == b - c ? $"{a}={b}-{c}" : a == b * c ? $"{a}={b}*{c}" : a == b / c ? $"{a}={b}/{c}" : "0w0");