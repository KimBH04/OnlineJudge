using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

var deque = new List<int>();
var n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    var command = sr.ReadLine().Split();

    switch (command[0])
    {
        case "push_front":
            deque.Add(int.Parse(command[1]));
            break;
        case "push_back":
            deque.Insert(0, int.Parse(command[1]));
            break;
        case "pop_front":
            if (deque.Count > 0)
            {
                sw.WriteLine(deque[^1]);
                deque.RemoveAt(deque.Count - 1);
            }
            else
            {
                sw.WriteLine(-1);
            }
            break;
        case "pop_back":
            if (deque.Count > 0)
            {
                sw.WriteLine(deque[0]);
                deque.RemoveAt(0);
            }
            else
            {
                sw.WriteLine(-1);
            }
            break;
        case "size":
            sw.WriteLine(deque.Count);
            break;
        case "empty":
            sw.WriteLine(deque.Count > 0 ? 0 : 1);
            break;
        case "front":
            sw.WriteLine(deque.Count > 0 ? deque[^1] : -1);
            break;
        case "back":
            sw.WriteLine(deque.Count > 0 ? deque[0] : -1);
            break;
    }
}