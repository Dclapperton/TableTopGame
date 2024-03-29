﻿using TableTopGame.Models.Commands;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame.Models
{
    public class Right : BaseCommand
    {
        const int OrientationLength = 3;

        public override void Execute()
        {
            if (IsValid())
            {
                Program.CurrentLocation.Orientation++;
            }
        }

        public override bool IsValid()
        {
            if (Program.CurrentLocation.Orientation == (Orientation)OrientationLength)
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
