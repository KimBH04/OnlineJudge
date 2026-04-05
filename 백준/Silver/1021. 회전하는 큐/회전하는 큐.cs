var input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), m = int.Parse(input[1]);

input = Console.ReadLine()!.Split();
var a = new int[m];
for (int i = 0; i < m; i++)
{
    a[i] = int.Parse(input[i]);
}

Deque<int> d1 = new(), d2 = new();
for (int i = 1; i <= n; i++)
{
    d1.PushBack(i);
    d2.PushBack(i);
}

var count = 0;

for (int i = 0; i < m; i++)
{
    while (true)
    {
        if (d1.PeekFront() == a[i])
        {
            d1.PopFront();
            d2 = d1.Copy();
            break;
        }
        if (d2.PeekFront() == a[i])
        {
            d2.PopFront();
            d1 = d2.Copy();
            break;
        }

        d1.PushFront(d1.PopBack());
        d2.PushBack(d2.PopFront());
        count++;
    }
}

Console.WriteLine(count);

public class Deque<T>
{
    private readonly List<T> m_Array;

    public int Count => m_Array.Count;

    public Deque()
    {
        m_Array = new();
    }

    public Deque<T> Copy()
    {
        Deque<T> rDeque = new();
        foreach (T t in m_Array)
        {
            rDeque.PushBack(t);
        }
        return rDeque;
    }

    public void PushFront(T item)
    {
        m_Array.Insert(0, item);
    }

    public T PopFront()
    {
        T r = m_Array[0];
        m_Array.RemoveAt(0);
        return r;
    }

    public void PushBack(T item)
    {
        m_Array.Add(item);
    }

    public T PopBack()
    {
        T r = m_Array[^1];
        m_Array.RemoveAt(m_Array.Count - 1);
        return r;
    }

    public T PeekFront()
    {
        return m_Array[0];
    }

    public T PeekBack()
    {
        return m_Array[^1];
    }
}