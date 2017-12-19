using System;

namespace TurtleMovement
{
    public static class Messages
    {
        public static void Instructions()
        {
            Console.WriteLine("Enter input here. Ex: PLACE 0,0,NORTH");
        }

        public static string ErrorMessage { get; set; } //holds the current error message

        public static void InvalidInput()
        {
            ErrorMessage = "\nINVALID INPUT. Input must be an integer between 1 - 7\n";
        }

    }
}
