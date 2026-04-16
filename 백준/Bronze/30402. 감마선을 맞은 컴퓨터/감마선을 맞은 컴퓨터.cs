for (int i = 0; i < 15; i++)
{
    string[] s = Console.ReadLine()!.Split();
    foreach (string c in s)
    {
        if (c == "w")
        {
            Console.WriteLine("chunbae");
            return;
        }
        if (c == "b")
        {
            Console.WriteLine("nabi");
            return;
        }
        if (c == "g")
        {
            Console.WriteLine("yeongcheol");
            return;
        }
    }
}
