using System;

namespace Prob3003
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] piece = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write(
                $"{1 - piece[0]} " +        //KING
                $"{1 - piece[1]} " +        //QUEEN
                $"{2 - piece[2]} " +        //ROOK
                $"{2 - piece[3]} " +        //BISHOP
                $"{2 - piece[4]} " +        //KNIGHT
                $"{8 - piece[5]} ");        //PAWN
        }
    }
}
