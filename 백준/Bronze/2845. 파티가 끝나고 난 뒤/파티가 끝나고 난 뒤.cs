var input = Console.ReadLine().Split();
int l = int.Parse(input[0]), p = int.Parse(input[1]);
var people = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

foreach (var person in people)
{
    Console.Write(person - l * p + " ");
}