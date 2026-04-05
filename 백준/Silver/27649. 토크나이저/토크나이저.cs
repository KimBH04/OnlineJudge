using var sw = new StreamWriter(Console.OpenStandardOutput());

var command = Console.ReadLine()!.ToCharArray();
var _fixed = new List<string>();

var word = "";
for (int i = 0; i < command.Length; i++)
{
    switch (command[i])
    {
        case '<':
        case '>':
        case '(':
        case ')':
            if (word.Length > 0)
            {
                _fixed.Add(word);
                word = "";
            }
            _fixed.Add(command[i].ToString());
            break;

        case '&':
        case '|':
            if (word.Length > 0)
            {
                _fixed.Add(word);
                word = "";
            }
            _fixed.Add(command[i].ToString() + command[++i].ToString());
            break;

        case ' ':
            if (word.Length > 0)
            {
                _fixed.Add(word);
                word = "";
            }
            break;

        default:
            word += command[i];
            break;
    }
}
_fixed.Add(word);

foreach (var w in _fixed)
{
    sw.Write(w + " ");
}