string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]), k = int.Parse(inputs[1]);

var grade = new int[7, 2];
while (n-- > 0)
{
    string[] line = Console.ReadLine()!.Split();
    int s = int.Parse(line[0]), y = int.Parse(line[1]);
    grade[y, s]++;
}

int x = 0;
foreach (int s in grade)
{
    x += s / k + (s % k > 0 ? 1 : 0);
}

Console.WriteLine(x);