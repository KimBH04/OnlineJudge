using System;

namespace Prob5622
{
    class Program
    {
        static void Main(string[] args)
        {
            int scd = 0;
            char[] word = Console.ReadLine().ToCharArray();
            for (int i = 0; i < word.Length; i++)
                switch(word[i])
                {
                    case 'A': case 'B': case 'C':
                        scd += 3;
                        break;
                        
                    case 'D': case 'E': case 'F':
                        scd += 4;
                        break;
                    
                    case 'G': case 'H': case 'I':
                        scd += 5;
                        break;
                    
                    case 'J': case 'K': case 'L':
                        scd += 6;
                        break;
                    
                    case 'M': case 'N': case 'O':
                        scd += 7;
                        break;
                    
                    case 'P': case 'Q': case 'R': case 'S':
                        scd += 8;
                        break;
                    
                    case 'T': case 'U': case 'V':
                        scd += 9;
                        break;

                    case 'W': case 'X': case 'Y': case 'Z':
                        scd += 10;
                        break;
                }
            Console.WriteLine(scd);
        }
    }
}
