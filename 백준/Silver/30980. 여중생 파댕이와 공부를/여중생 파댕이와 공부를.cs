using static System.Console;

string[] inputs = ReadLine()!.Split();
int n = int.Parse(inputs[0]), m = int.Parse(inputs[1]);

for (int i = 0; i < n; i++)
{
    string[] paper = { string.Empty, string.Empty, string.Empty };

    ReadLine();

    string shiks = ReadLine()!;
    for (int j = 0; j < m; j++)
    {
        int num = j * 8;

        string shik = shiks[(num + 1)..(num + 7)];
        int a = int.Parse(shik[0].ToString());
        int b = int.Parse(shik[2].ToString());
        int c = int.Parse(shik[^1] == '.' ? shik[^2].ToString() : shik[^2..]);

        if (a + b == c)
        {
            paper[0] += c / 10 > 0 ? ".******." : ".*****..";
            paper[1] += $"*{a}+{b}={c}*" + (c / 10 > 0 ? "" : ".");
            paper[2] += c / 10 > 0 ? ".******." : ".*****..";
        }
        else
        {
            paper[0] += ".../....";
            paper[1] += $".{a}/{b}={c}." + (c / 10 > 0 ? "" : ".");
            paper[2] += "./......";
        }
    }

    ReadLine();

    WriteLine(paper[0]);
    WriteLine(paper[1]);
    WriteLine(paper[2]);
}
