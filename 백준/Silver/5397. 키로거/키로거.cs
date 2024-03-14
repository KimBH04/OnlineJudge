int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    string input = Console.ReadLine()!;

    LinkedList<char> pass = new();
    LinkedListNode<char> cursor = pass.AddFirst('\n');

    foreach (char c in input)
    {
        switch (c)
        {
            case '<':
                cursor = cursor.Previous ?? cursor;
                break;

            case '>':
                cursor = cursor.Next ?? cursor;
                break;

            case '-':
                if (cursor.Previous != null)
                {
                    pass.Remove(cursor.Previous);
                }
                break;

            default:
                pass.AddBefore(cursor, c);
                break;
        }
    }
    Console.Write(string.Join(string.Empty, pass));
}
