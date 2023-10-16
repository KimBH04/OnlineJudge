int n = int.Parse(Console.ReadLine()!);
Stack<int> students = new(Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse).Reverse());
Stack<int> empty = new();

int i = 1;
while (i <= n)
{
    if (empty.Count > 0 && empty.Peek() == i)
    {
        empty.Pop();
        i++;
    }
    else if (students.Count > 0)
    {
        if (students.Peek() == i)
        {
            students.Pop();
            i++;
        }
        else
        {
            empty.Push(students.Pop());
        }
    }
    else
    {
        Console.WriteLine("Sad");
        return;
    }
}
Console.WriteLine("Nice");