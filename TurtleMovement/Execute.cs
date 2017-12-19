using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleMovement
{
    class Execute
    {
        static void Main(string[] args)
        {
            var turtle = new TurtleMove();
            turtle.TurtleMoveLoop();
            Console.ReadLine();
        }
    }
}
