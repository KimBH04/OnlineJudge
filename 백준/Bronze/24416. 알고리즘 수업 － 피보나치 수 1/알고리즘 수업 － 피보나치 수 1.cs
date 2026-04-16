int[] m = new int[41];
var n = int.Parse(Console.ReadLine());

m[0] = 0;
m[1] = 1;

for (int i = 2; i <= n; i++) m[i] = m[i - 1] + m[i - 2];

Console.WriteLine(m[n] + " " + (n - 2));