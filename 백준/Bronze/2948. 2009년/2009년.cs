string[] input = Console.ReadLine()!.Split();
Console.WriteLine(new DateTime(2009, int.Parse(input[1]), int.Parse(input[0])).DayOfWeek);