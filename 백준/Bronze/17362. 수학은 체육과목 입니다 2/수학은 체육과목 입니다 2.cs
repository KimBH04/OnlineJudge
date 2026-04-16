var n = int.Parse(Console.ReadLine()) - 1;
var d = n / 4;
var r = n % 4;

if (d % 2 == 0) Console.WriteLine(r + 1);
else Console.WriteLine(5 - r);