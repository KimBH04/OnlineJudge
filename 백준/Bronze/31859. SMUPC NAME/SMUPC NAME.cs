string[] inputs = Console.ReadLine()!.Split();
int n = int.Parse(inputs[0]);
string s = inputs[1];

var dist = s.Distinct();
Console.WriteLine($"smupc_{string.Join(string.Empty, (n + 1906 + string.Join(string.Empty, dist) + (s.Length - dist.Count() + 4)).Reverse())}");