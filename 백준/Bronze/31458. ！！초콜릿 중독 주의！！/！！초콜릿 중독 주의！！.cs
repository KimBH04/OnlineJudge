int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    string input = Console.ReadLine()!;
    string[] bang = input.Split('0', '1');
    bool n = input[bang[0].Length] > 48;
    Console.WriteLine((n || bang[1].Length > 0) ^ (bang[0].Length % 2 == 1) ? 1 : 0);
}
