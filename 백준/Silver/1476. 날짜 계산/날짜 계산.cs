string[] input = Console.ReadLine()!.Split();
int a = int.Parse(input[0]),
    b = int.Parse(input[1]),
    c = int.Parse(input[2]);

Earth e = 0;
Sun s = 0;
Moon m = 0;

for (int i = 0; ; i++, e++, s++, m++)
{
    if (a == e && b == s && c == m)
    {
        Console.WriteLine(i);
        break;
    }
}

public struct Earth
{
    private readonly int _value;

    public Earth(int value)
    {
        _value = value;
    }

    public static implicit operator Earth(int value)
    {
        if (value > 15)
            value = 1;

        return new Earth(value);
    }

    public static implicit operator int(Earth value)
    {
        return value._value;
    }
}

public struct Sun
{
    private readonly int _value;

    public Sun(int value)
    {
        _value = value;
    }

    public static implicit operator Sun(int value)
    {
        if (value > 28)
            value = 1;

        return new Sun(value);
    }

    public static implicit operator int(Sun value)
    {
        return value._value;
    }
}

public struct Moon
{
    private readonly int _value;

    public Moon(int value)
    {
        _value = value;
    }

    public static implicit operator Moon(int value)
    {
        if (value > 19)
            value = 1;

        return new Moon(value);
    }

    public static implicit operator int(Moon value)
    {
        return value._value;
    }
}