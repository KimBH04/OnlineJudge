Console.WriteLine(Triangle());

string Triangle()
{
    int _1 = int.Parse(Console.ReadLine()!),
        _2 = int.Parse(Console.ReadLine()!),
        _3 = int.Parse(Console.ReadLine()!);

    if (_1 + _2 + _3 == 180)
    {
        if (_1 == _2 && _2 == _3)
        {
            return "Equilateral";
        }
        if (_1 == _2 || _2 == _3 || _3 == _1)
        {
            return "Isosceles";
        }

        return "Scalene";
    }

    return "Error";
}