string[] inputs = Console.ReadLine()!.Split();
int month = inputs[0] switch
{
    "January" => 1,
    "February" => 2,
    "March" => 3,
    "April" => 4,
    "May" => 5,
    "June" => 6,
    "July" => 7,
    "August" => 8,
    "September" => 9,
    "October" => 10,
    "November" => 11,
    "December" => 12,
    _ => throw new InvalidDataException("Wait What"),
};
int day = int.Parse(inputs[1][..2]);
int year = int.Parse(inputs[2]);
inputs = inputs[3].Split(':');
int hour = int.Parse(inputs[0]);
int minute = int.Parse(inputs[1]);

DateTime dt = new(year, month, day, hour, minute, 0);
DateTime at = new(dt.Year, 1, 1, 0, 0, 0);
DateTime next = new(dt.Year + 1, 1, 1, 0, 0, 0);
Console.WriteLine((dt - at).TotalMilliseconds * 100d / (next - at).TotalMilliseconds);