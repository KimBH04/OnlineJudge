bool[] eratos = new bool[5_000_000];
for (int i = 0; i < 5_000_000; i++)
{
    eratos[i] = true;
}

eratos[0] = eratos[1] = false;
for (int i = 2; i < 5_000_000; i++)
{
    if (eratos[i])
    {
        for (int j = i + i; j < 5_000_000; j += i)
        {
            eratos[j] = false;
        }
    }
}

long dw = 0, ks = 0;
PriorityQueue<int, int> dwQ = new();
PriorityQueue<int, int> ksQ = new();
bool[] called = new bool[5_000_000];

int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int d = int.Parse(inputs[0]), k = int.Parse(inputs[1]);
    
    if (eratos[d])
    {
        if (called[d])
        {
            dw -= 1000;
        }
        else
        {
            called[d] = true;
            dwQ.Enqueue(d, -d);
        }
    }
    else
    {
        if (ksQ.Count < 3)
        {
            ks += 1000;
        }
        else
        {
            int first = ksQ.Dequeue();
            int second = ksQ.Dequeue();
            ks += ksQ.Peek();

            ksQ.Enqueue(first, -first);
            ksQ.Enqueue(second, -second);
        }
    }

    if (eratos[k])
    {
        if (called[k])
        {
            ks -= 1000;
        }
        else
        {
            called[k] = true;
            ksQ.Enqueue(k, -k);
        }
    }
    else
    {
        if (dwQ.Count < 3)
        {
            dw += 1000;
        }
        else
        {
            int first = dwQ.Dequeue();
            int second = dwQ.Dequeue();
            dw += dwQ.Peek();

            dwQ.Enqueue(first, -first);
            dwQ.Enqueue(second, -second);
        }
    }
}

if (dw > ks)
{
    Console.WriteLine("소수의 신 갓대웅");
}
else if (dw < ks)
{
    Console.WriteLine("소수 마스터 갓규성");
}
else
{
    Console.WriteLine("우열을 가릴 수 없음");
}
