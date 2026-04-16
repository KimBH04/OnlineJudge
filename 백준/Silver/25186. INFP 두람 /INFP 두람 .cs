var n = int.Parse(Console.ReadLine());
var d = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

var max = Max(d);
var sum = Sum(d);
Console.WriteLine(max <= sum / 2 || (max == 1 && sum == 1) ? "Happy" : "Unhappy");

static int Max(int[] arr)
{
    var max = int.MinValue;
	foreach (var item in arr)
	{
		if (item > max)
			max = item;
	}
	return max;
}

static long Sum(int[] arr)
{
	var sum = 0L;
	foreach (var item in arr)
	{
		sum += item;
	}
	return sum;
}