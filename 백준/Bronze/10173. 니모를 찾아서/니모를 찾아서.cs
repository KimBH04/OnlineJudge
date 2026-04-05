while (true)
{
    string s = Console.ReadLine()!;
    if (s == "EOI")
        break;

    Console.WriteLine(s.ToUpper().Contains("NEMO") ? "Found" : "Missing");
}
