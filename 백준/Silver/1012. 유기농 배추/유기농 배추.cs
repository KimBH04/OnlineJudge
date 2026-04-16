using System;

class Program
{
    static bool[,] hidafarm;

    static void Main(string[] args)
    {
        var t = int.Parse(Console.ReadLine());

        for (int time = 0; time < t; time++)
        {
            var cnt = 0;
            var input = Console.ReadLine().Split();

            var m = int.Parse(input[0]);    //가로
            var n = int.Parse(input[1]);    //세로

            var k = int.Parse(input[2]);    //배추수

            hidafarm = new bool[m, n];

            for (int i = 0; i < n; i++) 
                for (int j = 0; j < m; j++) 
                    hidafarm[j, i] = false;

            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine().Split();
                var x = int.Parse(input[0]);
                var y = int.Parse(input[1]);

                hidafarm[x, y] = true;
            }

            for (int x = 0; x < m; x++) 
                for (int y = 0; y < n; y++) 
                    if (hidafarm[x, y]) 
                    { 
                        Josa(x, y); 
                        cnt++; 
                    }

            Console.WriteLine(cnt);
        }
    }

    static void Josa(int x, int y)
    {
        hidafarm[x, y] = false;

        try { if (hidafarm[x + 1, y]) Josa(x + 1, y); } catch (Exception) { }
        try { if (hidafarm[x - 1, y]) Josa(x - 1, y); } catch (Exception) { }
        try { if (hidafarm[x, y + 1]) Josa(x, y + 1); } catch (Exception) { }
        try { if (hidafarm[x, y - 1]) Josa(x, y - 1); } catch (Exception) { }
    }
}