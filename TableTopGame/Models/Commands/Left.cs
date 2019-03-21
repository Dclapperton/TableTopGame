using System;
using TableTopGame.Models.Commands;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame.Models
{
    public class Left : BaseCommand
    {
        const int OrientationLength = 3;

        public override void Execute()
        {
            if (IsValid())
            {
                Program.CurrentLocation.Orientation--;
            }
        }

        public override bool IsValid()
        {
            int enumLength = Enum.GetValues(typeof(Orientation)).Length;

            if ((int)Program.CurrentLocation.Orientation == OrientationLength)
            {
                Program.CurrentLocation.Orientation = 0;

                return false;
            }
            else
            {
                return base.IsValid();
            }
        }
    }
}
