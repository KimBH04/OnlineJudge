var t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    var outputs = new List<int>();
    var input = Console.ReadLine().Split();
    int n = int.Parse(input[0]), m = int.Parse(input[1]);

    var impos = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var q = new Queue<int>();

    for (int j = 0; j < n; j++)
    {
        q.Enqueue(j);
    }

    while (q.Count > 0)
    {
        var idx = q.Dequeue();
        var impo = impos[idx];

        foreach (var item in impos)
        {
            if (item > impo)
            {
                q.Enqueue(idx);
                goto here;
            }
        }

        outputs.Add(idx);
        impos[idx] = int.MinValue;
    here:;
    }

    Console.WriteLine(outputs.IndexOf(m) + 1);
}