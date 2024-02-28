int n = int.Parse(Console.ReadLine()!);

int score = 0;
(int score, int time) task = (0, 0);
Stack<(int, int)> stack = new();
while (n-- > 0)
{
    string[] inputs = Console.ReadLine()!.Split();
    int q = int.Parse(inputs[0]);
    if (q == 1)
    {
        stack.Push(task);
        task = (int.Parse(inputs[1]), int.Parse(inputs[2]));
    }

    task.time--;

    if (task.time <= 0)
    {
        score += task.score;
        if (stack.Count > 0)
        {
            task = stack.Pop();
        }
        else
        {
            task = (0, 0);
        }
    }
}

Console.WriteLine(score);