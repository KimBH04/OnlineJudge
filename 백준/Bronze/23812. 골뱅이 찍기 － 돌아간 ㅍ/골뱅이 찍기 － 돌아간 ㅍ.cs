using StreamWriter sw = new(Console.OpenStandardOutput());
int n = int.Parse(Console.ReadLine()!);

var spinPieup = (string pattern) =>
{
    for (int i = 0; i < n; i++)
    {
        foreach (char c in pattern)
        {
            for (int j = 0; j < n; j++)
            {
                sw.Write(c);
            }
        }
        sw.WriteLine();
    }
};

spinPieup("@   @");
spinPieup("@@@@@");
spinPieup("@   @");
spinPieup("@@@@@");
spinPieup("@   @");