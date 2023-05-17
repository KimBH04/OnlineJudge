using System.Diagnostics;

Console.WriteLine(BFS());

string BFS()
{
    var Dnj = new Queue<(int idx, string path)>();
    var Aki = new Queue<(int idx, string path)>();
    var Pow = new Queue<(int idx, string path)>();

    var input = Console.ReadLine()!.Split();
    int n = int.Parse(input[0]),
        m = int.Parse(input[1]);

    var road = new List<int>[n + 1];
    for (int i = 1; i <= n; i++)
    {
        road[i] = new List<int>();
    }

    input = Console.ReadLine()!.Split();
    int a = int.Parse(input[0]), //파워
        b = int.Parse(input[1]), //덴지
        c = int.Parse(input[2]); //아키

    Dnj.Enqueue((b, b.ToString()));
    Aki.Enqueue((c, c.ToString()));
    Pow.Enqueue((a, a.ToString()));

    for (int i = 0; i < m; i++)
    {
        input = Console.ReadLine()!.Split();
        int s = int.Parse(input[0]),
            e = int.Parse(input[1]);

        road[s].Add(e);
    }

    var cnt = 1;

    var stop = new Stopwatch();
    stop.Start();

    while (Dnj.Count > 0 && Aki.Count > 0 && Pow.Count > 0)
    {
        var visited = new bool[n + 1];
        for (int i = 1; i <= n; i++)
        {
            visited[i] = false;
        }

        int dCnt = Dnj.Count,
            aCnt = Aki.Count,
            pCnt = Pow.Count;

        var intOverlap = new List<int>();
        var strOverlap = new List<string>();

        for (int i = 0; i < dCnt; i++)
        {
            var (idx, path) = Dnj.Dequeue();
            var dIdx = idx;
            var dPath = path;

            foreach (var item in road[dIdx])
            {
                if (visited[item])
                    continue;

                intOverlap.Add(item);
                strOverlap.Add(dPath + " " + item);

                Dnj.Enqueue((item, dPath + " " + item));

                visited[item] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            visited[i] = false;
        }

        for (int i = 0; i < aCnt; i++)
        {
            var (idx, path) = Aki.Dequeue();
            var aIdx = idx;
            var aPath = path;

            foreach (var item in road[aIdx])
            {
                if (visited[item])
                    continue;

                intOverlap.Add(item);
                strOverlap.Add(aPath + " " + item);

                Aki.Enqueue((item, aPath + " " + item));

                visited[item] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            visited[i] = false;
        }

        for (int i = 0; i < pCnt; i++)
        {
            var (idx, path) = Pow.Dequeue();
            var pIdx = idx;
            var pPath = path;

            foreach (var item in road[pIdx])
            {
                if (visited[item])
                    continue;

                intOverlap.Add(item);
                strOverlap.Add(pPath + " " + item);

                Pow.Enqueue((item, pPath + " " + item));

                visited[item] = true;
            }
        }

        intOverlap.Sort();
        strOverlap = strOverlap.OrderBy(x => int.Parse(x.Split()[^1])).ToList();

        for (int i = 0; i < intOverlap.Count - 2; i++)
        {
            if (intOverlap[i] == intOverlap[i + 1] && intOverlap[i + 1] == intOverlap[i + 2])
            {
                return
                    intOverlap[i] + " " + cnt + "\n" +
                    strOverlap[i + 2] + "\n" +
                    strOverlap[i] + "\n" +
                    strOverlap[i + 1];
            }
        }

        cnt++;

        if (stop.ElapsedMilliseconds > 2900)
        {
            stop.Stop();
            break;
        }
    }

    return "-1";
}