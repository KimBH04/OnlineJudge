using var sr = new StreamReader(Console.OpenStandardInput());

while (!sr.EndOfStream)
{
    var input = sr.ReadLine().Split();

    int n = int.Parse(input[0]), s = int.Parse(input[1]);
    Console.WriteLine(s / (n + 1));
}