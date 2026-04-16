using System;

namespace Prob2941
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] cro = Console.ReadLine().ToCharArray();
            int croAlpha = cro.Length;

            for (int i = 1; i < cro.Length; i++)
            {
                if (cro[i] == '='|| cro[i] == '-')
                {
                    croAlpha--;

                    if (i > 1 && cro[i - 1] == 'z')
                        if (cro[i - 2] == 'd')
                            croAlpha--;
                }

                else if(cro[i] == 'j')
                    if (cro[i - 1] == 'n' || cro[i - 1] == 'l')
                        croAlpha--;
            }

            Console.WriteLine(croAlpha);
        }
    }
}
