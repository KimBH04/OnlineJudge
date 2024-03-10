decimal a = decimal.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();
decimal m = decimal.Parse(inputs[0]), n = decimal.Parse(inputs[1]);

decimal b = m / a;
decimal c = n / a;

decimal[] arr = new decimal[6];
arr[0] = b * 2;
arr[1] = Math.Max(b, n);
arr[2] = n * 2;
arr[3] = c * 2;
arr[4] = Math.Max(m, c);
arr[5] = m * 2;
Console.WriteLine(arr.Min());