using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(sr.ReadLine()!);
var PQ = new PriorityQueue<int, float>();

while (n-- > 0)
{
    var x = int.Parse(sr.ReadLine()!);
    if (x == 0)
        if (PQ.Count > 0)
            sw.WriteLine(PQ.Dequeue());
        else
            sw.WriteLine(0);
    else
        PQ.Enqueue(x, Math.Abs(x + .1f));
}
