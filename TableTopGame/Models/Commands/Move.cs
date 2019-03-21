using System;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame.Models.Commands
{
    public class Move : BaseCommand
    {
        public override void Execute()
        {
            if (IsValid())
            {
                switch (Program.CurrentLocation.Orientation)
                {
                    case Orientation.NORTH:
                        Program.CurrentLocation.PositionY.Increment();
                        break;
                    case Orientation.EAST:
                        Program.CurrentLocation.PositionX.Increment();
                        break;
                    case Orientation.SOUTH:
                        Program.CurrentLocation.PositionY.Decrement();
                        break;
                    case Orientation.WEST:
                        Program.CurrentLocation.PositionX.Decrement();
                        break;
                    default:
                        Console.WriteLine("Orientation not found.");
                        break;
                }
            }
        }
    }
}
