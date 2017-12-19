using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleMovement
{
    public class TurtleMovementArea
    {
        public const int AreaSize = 5; //defualt size
        public const char markSpace = 'X';

        public TurtleMovementArea()
        {
            GameBoardArray = new char[AreaSize, AreaSize];
        }

        public static char[,] GameBoardArray { get; set; }
        public static void UpdateMovementAreaX(int start, int iteration, int increment, int constant)
        {
            for (var i = 0; i < iteration; i++)
            {
                GameBoardArray[start + (i * increment), constant] = markSpace;
            }
        }

        public static void UpdateMovementAreaY(int start, int iteration, int increment, int constant)
        {
            for (var i = 0; i < iteration; i++)
            {
                GameBoardArray[constant, start + (i * increment)] = markSpace;
            }
        }
    }
}
