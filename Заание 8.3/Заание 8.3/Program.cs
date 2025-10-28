using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заание_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого слона");
            var whitePawnPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного ферзя");
            var blackPawnPosition = Console.ReadLine();

            if (whitePawnPosition == blackPawnPosition)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке");
                return;
            }

            int whitePawnH, whitePawnV;
            int blackPawnH, blackPawnV;

            DecodePosition(whitePawnPosition, out whitePawnV, out whitePawnH);
            DecodePosition(blackPawnPosition, out blackPawnV, out blackPawnH);

            if (IsUnderStrikeByBlackPawn(whitePawnPosition, blackPawnPosition) ||
                IsUnderStrikeByWhitePawn(blackPawnPosition, whitePawnPosition))
                Console.WriteLine("Фигуры бьют друг друга");
            else
                Console.WriteLine("Фигуры не бьют друг друга");

        }

        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());
        }

        static bool IsUnderStrikeByWhitePawn(string position, string whitePawnPostition)
        {
            int pV, pH, wpV, wpH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(whitePawnPostition, out wpV, out wpH);

            return pH - wpH == 1 && Math.Abs(pV - wpV) == 1;
        }

        static bool IsUnderStrikeByBlackPawn(string position, string blackPawnPostition)
        {
            int pV, pH, bpV, bpH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(blackPawnPostition, out bpV, out bpH);

            return bpH - pH == 1 && Math.Abs(pV - bpV) == 1;
        }
    }
}