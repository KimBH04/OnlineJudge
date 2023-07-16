int n = int.Parse(Console.ReadLine()!);

while (n-- > 0)
{
    string[] input = Console.ReadLine()!.Split('-');

    int lll = 0;
    for (int i = 0; i < 3; i++)
    {
        lll += (input[0][i] - 65) * (int)Math.Pow(26, 2 - i);
    }

    int dddd = int.Parse(input[1]);


    Console.WriteLine((Math.Abs(lll - dddd) > 100 ? "not " : "") + "nice");
}
