using System;

namespace Cpppp
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var h = int.Parse(input[0]);
            var w = int.Parse(input[1]);

            var chessboad = new char[w, h];

            for (int y = 0; y < h; y++)
            {
                var input0 = Console.ReadLine().ToCharArray();
                for (int x = 0; x < w; x++)
                {
                    chessboad[x, y] = input0[x];
                }
            }

            var finalRepaintingCnt = int.MaxValue;
            var perfectChessboad = PerfectChessboad(true);

            for (int i = 0; i < h - 7; i++)
            {
                for (int j = 0; j < w - 7; j++)
                {
                    var repaintingCnt = RepaintingChessboad(chessboad, perfectChessboad, j, i);

                    if (repaintingCnt < finalRepaintingCnt)
                    {
                        finalRepaintingCnt = repaintingCnt;
                    }
                }
            }

            perfectChessboad = PerfectChessboad(false);

            for (int i = 0; i < h - 7; i++)
            {
                for (int j = 0; j < w - 7; j++)
                {
                    var repaintingCnt = RepaintingChessboad(chessboad, perfectChessboad, j, i);

                    if (repaintingCnt < finalRepaintingCnt)
                    {
                        finalRepaintingCnt = repaintingCnt;
                    }
                }
            }

            Console.WriteLine(finalRepaintingCnt);
        }

        static int RepaintingChessboad(char[,] chessboad, char[,] perfectChessboad,int width, int height)
        {
            var repaintingAreaCnt = 0;

            for (int y = height, py = 0; py < 8; y++, py++)
            {
                for (int x = width, px = 0; px < 8; x++, px++)
                {
                    if (chessboad[x, y] != perfectChessboad[px, py])
                    {
                        repaintingAreaCnt++;
                    }
                }
            }

            return repaintingAreaCnt;
        }

        static char[,] PerfectChessboad(bool turn)
        {
            var perfectChessboad = new char[8, 8];

            if (!turn)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            perfectChessboad[j, i] = 'W';
                        }
                        else
                        {
                            perfectChessboad[j, i] = 'B';
                        }
                    }
                }

            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            perfectChessboad[j, i] = 'B';
                        }
                        else
                        {
                            perfectChessboad[j, i] = 'W';
                        }
                    }
                }
            }

            return perfectChessboad;
        }
    }
}
