const string YES = "YES", NO = "NO";

using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

var n = int.Parse(sr.ReadLine());

var x = 1;
var dir = true;
for (int i = 0; i < n; i++)
{
    var YesOrNo = false;
    var I = sr.ReadLine().Split();

    var ifs = I[0] == "HOURGLASS";
    var ifx = I[1] == x.ToString();

    if (!(ifs && ifx))
    {
        if (ifs)
        {
            dir = !dir;
        }
        else if (ifx)
        {
            YesOrNo = true;
        }
    }

    sw.Write(x + " ");

    if (YesOrNo) sw.WriteLine(YES);
    else sw.WriteLine(NO);

    if (dir) x++;
    else x--;
    if (x > 12) x = 1;
    else if (x < 1) x = 12;
}