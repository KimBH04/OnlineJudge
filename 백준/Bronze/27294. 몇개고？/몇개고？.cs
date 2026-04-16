var input = Console.ReadLine().Split();
int t = int.Parse(input[0]), k = int.Parse(input[1]);
if (k == 1 || (t < 12 || t > 16))Console.WriteLine(280);
else Console.WriteLine(320);