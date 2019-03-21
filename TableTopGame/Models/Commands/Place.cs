

using System;
using TableTopGame.Interfaces;
using TableTopGame.Models.Commands;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame.Models
{
    public class Place : BaseCommand
    {
        public string[] NewParameters { get { return Parameters.Split(','); } }

        public override void Execute()
        {
            if (IsValid())
            {
                SetLocation(int.Parse(NewParameters[0]), int.Parse(NewParameters[1]), NewParameters[2]);
            }
            else
            {
                Console.WriteLine("The PLACE command can only be used once.");
            }
        }

        private void SetLocation(int posX, int posY, string direction)
        {
            Orientation orientation;
            bool isValidOrientation = Enum.TryParse(direction, out orientation);

            if (isValidOrientation)
            {
                Program.CurrentLocation.PositionX = new PositionX() { Value = posX };
                Program.CurrentLocation.PositionY = new PositionY() { Value = posY };
                Program.CurrentLocation.Orientation = orientation;
                Program.CurrentLocation.Initialised = true;
            }
            else
            {
                Console.WriteLine("Invalid PLACE command.");
            }
        }

        public override bool IsValid()
        {
            return base.IsValid() && Program.CurrentLocation.Initialised == false;
        }
    }
}
