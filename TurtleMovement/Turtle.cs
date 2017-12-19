using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleMovement
{
    public class Turtle
    {
        public Turtle()
        {
            PositionX = 0;
            PositionY = 0;
        }

        public int Direction { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        //walk is calculated based on selected direction, number of spaces, and pen action (up = no draw, down = to draw)
        public void WalkX(Directions.TurtleDirections direction, int step)
        {
            if (ValidateMove(direction, step))
            {
                switch (direction)
                {
                    case Directions.TurtleDirections.NORTH:
                        PositionX -= step;
                        break;
                    case Directions.TurtleDirections.SOUTH:
                        TurtleMovementArea.UpdateMovementAreaX(PositionX, step, +1, PositionY);
                        PositionX += step;
                        break;
                }
            }
        }


        public void WalkY(Directions.TurtleDirections direction, int step)
        {
            if (ValidateMove(direction, step))
            {
                switch (direction)
                {
                    case Directions.TurtleDirections.EAST:
                        TurtleMovementArea.UpdateMovementAreaY(PositionY, step, +1, PositionX);
                        PositionY += step;
                        break;
                    case Directions.TurtleDirections.WEST:
                        TurtleMovementArea.UpdateMovementAreaY(PositionY, step, -1, PositionX);
                        PositionY -= step;
                        break;
                }
            }
        }

        private bool ValidateMove(Directions.TurtleDirections direction, int spaces)
        {
            if (direction == Directions.TurtleDirections.NORTH && (PositionX - spaces) < 0)
            {
                Messages.InvalidInput();
                return false;
            }
            else if (direction == Directions.TurtleDirections.EAST && (PositionY + spaces) > TurtleMovementArea.AreaSize)
            {
                Messages.InvalidInput();
                return false;
            }
            else if (direction == Directions.TurtleDirections.SOUTH && (PositionX + spaces) > TurtleMovementArea.AreaSize)
            {
                Messages.InvalidInput();
                return false;
            }
            else if (direction == Directions.TurtleDirections.WEST && (PositionY - spaces) < 0)
            {
                Messages.InvalidInput();
                return false;
            }

            return true;
        }
    }
}
