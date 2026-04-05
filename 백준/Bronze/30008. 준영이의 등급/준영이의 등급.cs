string[] input = Console.ReadLine()!.Split();
int n = int.Parse(input[0]), k = int.Parse(input[1]);

input = Console.ReadLine()!.Split();
for (int i = 0; i < k; i++)
{
    int g = int.Parse(input[i]) * 100 / n;
    Console.Write((g>96?9:g>89?8:g>77?7:g>60?6:g>40?5:g>23?4:g>11?3:g>4?2:1) + " ");
}