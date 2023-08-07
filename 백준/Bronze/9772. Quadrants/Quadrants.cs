using StreamReader sr = new(Console.OpenStandardInput());

do
{
    string[] input = sr.ReadLine()!.Split();
    float x = float.Parse(input[0]), y = float.Parse(input[1]);
    if (x == 0 || y == 0)
    {
        Console.WriteLine("AXIS");
    }
    else if (x > 0)
    {
        if (y > 0)
        {
            Console.WriteLine("Q1");
        }
        else
        {
            Console.WriteLine("Q4");
        }
    }
    else
    {
        if (y > 0)
        {
            Console.WriteLine("Q2");
        }
        else
        {
            Console.WriteLine("Q3");
        }
    }
} while (!sr.EndOfStream);