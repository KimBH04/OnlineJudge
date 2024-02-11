string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), l = int.Parse(inputs[1]);

inputs = Console.ReadLine()!.Split();
int[] arr = new int[n];

using StreamWriter sw = new(Console.OpenStandardOutput(), bufferSize: n);
PriorityQueue<int, int> pq = new(n);
Dictionary<int, int> appCnt = new(n);
for (int i = 0; i < n; i++)
{
    int a = arr[i] = int.Parse(inputs[i]);
    if (appCnt.ContainsKey(a))
    {
        appCnt[a]++;
    }
    else
    {
        appCnt.Add(a, 1);
    }

    if (i >= l)
    {
        appCnt[arr[i - l]]--;
    }

    if (pq.Count > 0)
    {
        int p = pq.Peek();
        if (p != a)
        {
            pq.Enqueue(a, a);
        }
    }
    else
    {
        pq.Enqueue(a, a);
    }

RePeek:
    int e = pq.Peek();
    if (appCnt[e] == 0)
    {
        pq.Dequeue();
        goto RePeek;
    }

    sw.Write(e + " ");
}
