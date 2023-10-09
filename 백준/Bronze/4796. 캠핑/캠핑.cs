for (int i = 1; ; i++)
{
    string[] input = Console.ReadLine()!.Split();
    int l = int.Parse(input[0]), p = int.Parse(input[1]), v = int.Parse(input[2]);
    if (l == 0 && p == 0 && v == 0)
        break;

    Console.WriteLine($"Case {i}: {v / p * l + (v % p < l ? v % p : l)}");
}
