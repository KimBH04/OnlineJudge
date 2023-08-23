using MyNamespace;

class P
{
    static event MyEvent? Event;

    static readonly StreamWriter sw = new(Console.OpenStandardOutput());
    static int i = 0;

    static void Main()
    {
        for (; ; )
        {
            string s = Console.ReadLine()!;
            if (s == "0")
                break;

            Event += () =>
            {
                sw.WriteLine($"Case {++i}: Sorting... done!");
            };
        }

        Event!();
        sw.Close();
    }
}

namespace MyNamespace
{
    public delegate void MyEvent();
}