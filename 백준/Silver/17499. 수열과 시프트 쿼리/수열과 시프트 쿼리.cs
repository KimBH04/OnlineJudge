using StreamReader sr = new(Console.OpenStandardInput());
using StreamWriter sw = new(Console.OpenStandardOutput());

string[] inputs = sr.ReadLine()!.Split();
int n = int.Parse(inputs[0]), q = int.Parse(inputs[1]), b = 0;

inputs = sr.ReadLine()!.Split();
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = int.Parse(inputs[i]);
}

while (q-- > 0)
{
    inputs = sr.ReadLine()!.Split();
    switch (inputs[0])
    {
        case "1":
            int i = int.Parse(inputs[1]) - 1, x = int.Parse(inputs[2]);
            if (b + i >= n)
            {
                a[i - n + b] += x;
            }
            else
            {
                a[b + i] += x;
            }

            break;

        case "2":
            int s1 = int.Parse(inputs[1]);
            b -= s1;
            if (b < 0)
            {
                b += n;
            }

            break;

        case "3":
            int s2 = int.Parse(inputs[1]);
            b += s2;
            if (b >= n)
            {
                b -= n;
            }
            
            break;
    }
}

for (int i = b; i < b + n; i++)
{
    sw.Write($"{(i < n ? a[i] : a[i - n])} ");
}