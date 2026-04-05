var m = new long[101];
m[0] = m[1] = m[2] = 1;
for (int i = 3; i < 101; i++) m[i] = m[i - 3] + m[i - 2];

var n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++) Console.WriteLine(m[int.Parse(Console.ReadLine()) - 1]);