foreach (var item in Console.ReadLine())
{
    Console.Write((int)item > 95 ? (char)(item - 32) : (char)(item + 32));
}