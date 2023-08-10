var sum = 0;
for (var i = 0; i < 4; i++)
{
    sum += int.Parse(Console.ReadLine()!);
}
Console.WriteLine(sum / 60 + "\n" + sum % 60);