using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

int t = int.Parse(sr.ReadLine()!);
while (t-- > 0)
{
    Dictionary<int, int> elementCounts = new();
    PriorityQueue<int, int> front = new();
    PriorityQueue<int, long> back = new();

    int k = int.Parse(sr.ReadLine()!);
    while (k-- > 0)
    {
        string[] command = sr.ReadLine()!.Split();
        int n = int.Parse(command[1]);
        switch (command[0])
        {
            case "I":
                front.Enqueue(n, n);
                back.Enqueue(n, -(long)n);
                if (elementCounts.ContainsKey(n))
                {
                    elementCounts[n]++;
                }
                else
                {
                    elementCounts.Add(n, 1);
                }
                break;

            case "D":
                if (n > 0)
                {
                ReDequeue:
                    if (back.Count > 0)
                    {
                        int max = back.Dequeue();
                        if (elementCounts[max] == 0)
                        {
                            goto ReDequeue;
                        }
                        else
                        {
                            elementCounts[max]--;
                        }
                    }
                }
                else
                {
                ReDequeue:
                    if (front.Count > 0)
                    {
                        int min = front.Dequeue();
                        if (elementCounts[min] == 0)
                        {
                            goto ReDequeue;
                        }
                        else
                        {
                            elementCounts[min]--;
                        }
                    }
                }
                break;

            default:
                break;
        }
    }

    while (front.TryPeek(out int e, out _))
    {
        if (elementCounts[e] > 0)
        {
            break;
        }
        else
        {
            front.Dequeue();
        }
    }

    while (back.TryPeek(out int e, out _))
    {
        if (elementCounts[e] > 0)
        {
            break;
        }
        else
        {
            back.Dequeue();
        }
    }

    if (front.Count > 0 && back.Count > 0)
    {
        sw.WriteLine($"{back.Dequeue()} {front.Dequeue()}");
    }
    else
    {
        sw.WriteLine("EMPTY");
    }
}
