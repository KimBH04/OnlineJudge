int n = int.Parse(Console.ReadLine()!);
string s = Console.ReadLine()!;

Dictionary<char, bool> rainbow = new()
{
    { 'r', false },
    { 'o', false },
    { 'y', false },
    { 'g', false },
    { 'b', false },
    { 'i', false },
    { 'v', false },

    { 'R', false },
    { 'O', false },
    { 'Y', false },
    { 'G', false },
    { 'B', false },
    { 'I', false },
    { 'V', false },
};

foreach (char c in s)
{
    if (rainbow.ContainsKey(c))
    {
        rainbow[c] = true;
    }
}

bool small = rainbow['r'] && rainbow['o'] && rainbow['y'] && rainbow['g'] && rainbow['b'] && rainbow['i'] && rainbow['v'];
bool large = rainbow['R'] && rainbow['O'] && rainbow['Y'] && rainbow['G'] && rainbow['B'] && rainbow['I'] && rainbow['V'];
if (small && large)
{
    Console.WriteLine("YeS");
}
else if (small)
{
    Console.WriteLine("yes");
}
else if (large)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO!");
}
