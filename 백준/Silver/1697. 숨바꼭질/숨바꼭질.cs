var visited = Enumerable.Repeat(false, 100001).ToArray();
var Q = new Queue<(int idx, int count)>();

var input = Console.ReadLine().Split();
int n = int.Parse(input[0]), k = int.Parse(input[1]);

Q.Enqueue((n, 0));

while (Q.Count > 0)
{
    var x = Q.Dequeue();
    int idx = x.idx, count = x.count;

    if (idx == k)
    {
        Console.WriteLine(count);
        break;
    }

    visited[idx] = true;
    int back = idx - 1, front = idx + 1, twice = idx * 2;

    if (Visit(back, visited))
    {
        Q.Enqueue((back, count + 1));
    }
    if (Visit(front, visited))
    {
        Q.Enqueue((front, count + 1));
    }
    if (Visit(twice, visited))
    {
        Q.Enqueue((twice, count + 1));
    }
}

static bool Visit(int idx, bool[] arr)
{
    if (idx >= 0 && idx <= 100000)
    {
        if (!arr[idx])
        {
            return true;
        }
    }

    return false;
}