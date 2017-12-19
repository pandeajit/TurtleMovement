namespace TurtleMovement
{
    public static class Directions
    {
        private static TurtleDirections _direction;
        public enum TurtleDirections
        {
            NORTH = 1,
            EAST = 2,
            SOUTH = 3,
            WEST = 4
        };

        public static TurtleDirections Direction
        {
            get { return _direction; }
            set
            {
                switch ((int)value)
                {
                    case 3:
                        _direction = TurtleDirections.NORTH;
                        break;
                    case 4:
                        _direction = TurtleDirections.EAST;
                        break;
                    case 5:
                        _direction = TurtleDirections.SOUTH;
                        break;
                    case 6:
                        _direction = TurtleDirections.WEST;
                        break;
                }
            }
        }
    }
}
