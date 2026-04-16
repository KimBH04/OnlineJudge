var n = int.Parse(Console.ReadLine());
Console.ReadLine();
var y = true;
for (int i = 2; i <= Math.Sqrt(n); i++)
{
    if (n % i == 0)
    {
        y = false;
        break;
    }
}

Console.WriteLine(y ? "Yes" : "No");