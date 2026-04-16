var abc = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
Array.Sort(abc);

while (abc[2] >= abc[0] + abc[1])
{
    abc[2]--;
}
Console.WriteLine(abc.Sum());