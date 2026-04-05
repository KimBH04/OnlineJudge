var memo = new int[11];
memo[1] = 1;
memo[2] = 2;
memo[3] = 4;
for (int i = 4; i < 11; i++)
{
    memo[i] = memo[i - 1] + memo[i - 2] + memo[i - 3];
}

var t = int.Parse(Console.ReadLine()!);

for (int i = 0; i < t; i++)
{
    var n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(memo[n]);
}