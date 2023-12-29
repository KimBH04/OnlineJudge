(char, char)[] nodes = new (char, char)[128];

int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    string inputs = Console.ReadLine()!;
    nodes[inputs[0]] = (inputs[2], inputs[4]);
}

Preorder('A');
Console.WriteLine();

Inorder('A');
Console.WriteLine();

Postorder('A');

void Preorder(char n)
{
    var (left, right) = nodes[n];

    Console.Write(n);

    if (left >= 65)
    {
        Preorder(left);
    }

    if (right >= 65)
    {
        Preorder(right);
    }
}

void Inorder(char n)
{
    var (left, right) = nodes[n];

    if (left >= 65)
    {
        Inorder(left);
    }

    Console.Write(n);

    if (right >= 65)
    {
        Inorder(right);
    }
}

void Postorder(char n)
{
    var (left, right) = nodes[n];

    if (left >= 65)
    {
        Postorder(left);
    }

    if (right >= 65)
    {
        Postorder(right);
    }

    Console.Write(n);
}
