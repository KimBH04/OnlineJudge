using System;

namespace prob1212
{
    class Program
    {
        static void Main(string[] args)
        {
            using var sr = new System.IO.StreamReader(Console.OpenStandardInput());
            using var sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

            var input = sr.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                int _int;
                string s = "";
                s += input[i];
                _int = int.Parse(s);
                s = Convert.ToString(_int, 2);
                _int = int.Parse(s);

                if (i != 0)
                {
                    sw.Write("{0:000}", _int);
                }
                else
                {
                    sw.Write(_int);
                }
            }
        }
    }
}
