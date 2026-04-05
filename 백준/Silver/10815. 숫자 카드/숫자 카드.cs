using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());


var n = int.Parse(sr.ReadLine());
var s = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
Array.Sort(s);
sr.ReadLine();
var c = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);


foreach (var i in c)
{
    int l = 0, r = n - 1;
	while (true)
	{
        var m = (l + r) / 2;

        if (l == r)
        {
            if (s[m] == i)
            {
                sw.Write(1 + " ");
                break;
            }

            sw.Write(0 + " ");
            break;
        }

        if (s[m] > i)
		{
			r = m == r ? m - 1 : m;
		}
		else if (s[m] < i)
		{
			l = m == l ? m + 1 : m;
        }
        else
        {
            sw.Write(1 + " ");
            break;
        }
    }
}