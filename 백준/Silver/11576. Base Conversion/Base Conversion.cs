string[] inputs = Console.ReadLine()!.Split();
int a = int.Parse(inputs[0]), b = int.Parse(inputs[1]);

int m = int.Parse(Console.ReadLine()!);
inputs = Console.ReadLine()!.Split();
int[] digits = new int[m];
for (int i = 0; i < m; i++)
{
    digits[i] = int.Parse(inputs[i]);
}

int @decimal = 0;
for (int i = m - 1, aBase = 1; i >= 0; i--, aBase *= a)
{
    @decimal += digits[i] * aBase;
}

List<int> bBase = new();
while (@decimal > 0)
{
    bBase.Add(@decimal % b);
    @decimal /= b;
}

Console.WriteLine(string.Join(' ', bBase.Reverse<int>()));