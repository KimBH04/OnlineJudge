string[] i = Console.ReadLine()!.Split();
int m = 1440 * int.Parse(i[1]) / int.Parse(i[0]);
Console.WriteLine($"{m / 60:00}:{m % 60:00}");