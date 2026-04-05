int n = int.Parse(Console.ReadLine()!);
string[] inputs = Console.ReadLine()!.Split();
int[] balloon = new int[n];
bool[] isPopped = new bool[n];
for (int i = 0; i < n; i++)
{
    balloon[i] = int.Parse(inputs[i]);
    isPopped[i] = false;
}

int pointer = 0;
for (int i = 0; i < n; i++)
{
    Console.Write(pointer + 1 + " ");
    if (i == n - 1)
        break;

    isPopped[pointer] = true;

    int count = balloon[pointer];
    if (count > 0)
    {
        while (count > 0)
        {
            pointer++;
            if (pointer >= n)
            {
                pointer -= n;
            }

            if (!isPopped[pointer])
            {
                count--;
            }
        }
    }
    else
    {
        count = -count;
        while (count > 0)
        {
            pointer--;
            if (pointer < 0)
            {
                pointer += n;
            }

            if (!isPopped[pointer])
            {
                count--;
            }
        }
    }
}