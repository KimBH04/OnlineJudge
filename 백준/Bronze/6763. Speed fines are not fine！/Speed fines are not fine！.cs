int l = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if (l >= c)
{
    Console.WriteLine("Congratulations, you are within the speed limit!");
}
else
{
    if (c - l < 21)
    {
        Console.WriteLine("You are speeding and your fine is $100.");
    }
    else if (c - l < 31)
    {
        Console.WriteLine("You are speeding and your fine is $270.");
    }
    else
    {
        Console.WriteLine("You are speeding and your fine is $500.");
    }
}
