int i = 3;
while (i-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int h1 = int.Parse(inputs[0]),
        m1 = int.Parse(inputs[1]),
        s1 = int.Parse(inputs[2]);
    int h2 = int.Parse(inputs[3]),
        m2 = int.Parse(inputs[4]),
        s2 = int.Parse(inputs[5]);

    TimeSpan time1 = new(h1, m1, s1), time2 = new(h2, m2, s2);

    TimeSpan time = time2 - time1;
    Console.WriteLine($"{time.Hours} {time.Minutes} {time.Seconds}");
}
