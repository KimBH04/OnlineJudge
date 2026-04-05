var n = int.Parse(Console.ReadLine());
var s = Console.ReadLine().ToCharArray();
for (int i = 1; i < n; i++) if (s[i - 1] == s[i]) s[i - 1] = s[i] = (char)(s[i] - 32);
foreach(char c in s) Console.Write(c);