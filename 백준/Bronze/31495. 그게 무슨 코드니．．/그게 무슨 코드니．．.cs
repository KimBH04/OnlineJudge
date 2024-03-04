string input = Console.ReadLine()!;
Console.WriteLine(input.Length > 2 && input[0] == input[^1] && input[0] == '\"' ? input[1..^1] : "CE");