using MarsExplorer.Global;
using System;

namespace MarsExplorer.Business
{
    public class Explorer :IExplorer
    {
        public Rover Operation(char cmd, Rover rover)
        {
            switch (cmd)
            {
                case 'L': rover.Turn(Enums.Sides.Left); break;
                case 'R': rover.Turn(Enums.Sides.Right); break;
                case 'M': rover.Move(Enums.Way.Forward); break;
                case 'B': rover.Move(Enums.Way.Backward); break;
                default: throw new ArgumentException("Invalid Command");
            }
            return rover;
        }
    }
}
