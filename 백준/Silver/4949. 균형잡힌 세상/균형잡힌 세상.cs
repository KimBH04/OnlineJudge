using System;

namespace Prob4949
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var ls = new System.Collections.Generic.List<char>();
                var _string = Console.ReadLine().ToCharArray();
                if (_string.Length == 1 && _string[0] == '.')
                    break;

                foreach (var item in _string)
                {
                    try
                    {
                        switch (item)
                        {
                            case '(':
                            case '[':
                                ls.Add(item);
                                break;

                            case ')':
                                if (ls[^1] == '(') ls.RemoveAt(ls.Count - 1);
                                else throw new ArgumentOutOfRangeException();
                                break;

                            case ']':
                                if (ls[^1] == '[') ls.RemoveAt(ls.Count - 1);
                                else throw new ArgumentOutOfRangeException();
                                break;

                            default:
                                break;
                        }
                    }
                    catch (ArgumentOutOfRangeException) { ls.Add(' '); break; }
                }

                if (ls.Count == 0) Console.WriteLine("yes");
                else Console.WriteLine("no");
            }
        }
    }
}
