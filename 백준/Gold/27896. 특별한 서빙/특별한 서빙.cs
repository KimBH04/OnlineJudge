string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]),
    m = int.Parse(input[1]);

PriorityQueue<int, int> pq = new();
input = Console.ReadLine()!.Split();

int b = 0;
int r = 0;
for (int i = 0; i < n; i++)
{
    int x = int.Parse(input[i]);
    b += x;
    pq.Enqueue(x, -x);

    if (b >= m)
    {
        int a = pq.Dequeue();
        b -= a + a;
        r++;
    }
}

Console.WriteLine(r);