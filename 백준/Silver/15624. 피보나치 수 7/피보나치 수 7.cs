int[] fibonacci = new int[1000001];
fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < 1000001; i++)
{
    fibonacci[i] = (fibonacci[i - 1] + fibonacci[i - 2]) % 1000000007;
}

int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(fibonacci[n]);