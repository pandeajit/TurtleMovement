using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleMovement
{
    public class TurtleMove
    {
        private Turtle _turtle;
        private bool _quit; //quit the game
        private TurtleMovementArea turtleMovementArea;

        public TurtleMove()
        {
            _turtle = new Turtle();
            turtleMovementArea = new TurtleMovementArea();
            _quit = false;
        }

        public void TurtleMoveLoop()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(Messages.ErrorMessage);
                Messages.Instructions();
                List<string> lines = new List<string>();

                var currentLine = Console.ReadLine();
                while (currentLine != "REPORT")
                {
                    lines.Add(currentLine);
                    currentLine = Console.ReadLine();
                }

                if (lines.Any(s => s.Contains("PLACE")))
                {
                    var inputs = lines.Where(s => s.Contains("PLACE")).FirstOrDefault().Split(',').ToList();
                    var xPos = Convert.ToInt32(inputs[0].Replace("PLACE", ""));
                    var yPos = Convert.ToInt32(inputs[1]);

                    var direction = Enum.TryParse(inputs[2], out Directions.TurtleDirections turtleDirections);
                    _turtle.WalkX(turtleDirections, xPos);
                    _turtle.WalkY(turtleDirections, yPos);

                    foreach (var item in lines)
                    {
                        if (!item.Contains("PLACE"))
                        {
                            if (item == "MOVE")
                            {
                                if (turtleDirections == Directions.TurtleDirections.NORTH || turtleDirections == Directions.TurtleDirections.NORTH)
                                {
                                    _turtle.WalkX(turtleDirections, 1);
                                }
                                else if (turtleDirections == Directions.TurtleDirections.EAST || turtleDirections == Directions.TurtleDirections.WEST)
                                {
                                    _turtle.WalkY(turtleDirections, 1);
                                }
                            }
                        }
                    }

                    Console.WriteLine(_turtle.PositionX + _turtle.PositionY);
                }

                _quit = true;
            } while (!_quit);
        }
    }
}
