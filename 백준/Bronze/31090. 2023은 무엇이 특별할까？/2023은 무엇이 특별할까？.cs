int t = int.Parse(Console.ReadLine()!);
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine((n + 1) % (n % 100) == 0 ? "Good" : "Bye");
}