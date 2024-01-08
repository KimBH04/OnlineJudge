LinkedList<char> ll = new(Console.ReadLine()! + '\n');
LinkedListNode<char> cursor = ll.Last!;

int m = int.Parse(Console.ReadLine()!);
while (m-- > 0)
{
    string input = Console.ReadLine()!;
    switch (input[0])
    {
        case 'L':
            cursor = cursor.Previous ?? cursor;
            break;

        case 'D':
            cursor = cursor.Next ?? cursor;
            break;

        case 'B':
            if (cursor.Previous != null)
            {
                ll.Remove(cursor.Previous);
            }
            break;

        case 'P':
            ll.AddBefore(cursor, input[2]);
            break;
    }
}

using StreamWriter sw = new(Console.OpenStandardOutput());

foreach (char c in ll)
{
    sw.Write(c);
}
