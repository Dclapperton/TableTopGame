using System;
using TableTopGame.Interfaces;
using TableTopGame.Models.Commands;

namespace TableTopGame.Models
{
    public class Report : BaseCommand
    {
        public override void Execute()
        {
            if (IsValid())
            {
                Console.WriteLine($"{Program.CurrentLocation.PositionX.Value},{Program.CurrentLocation.PositionY.Value},{Program.CurrentLocation.Orientation}");
            }
            else
            {
                Console.WriteLine("Invalid report command.");
            }
        }

        public override bool IsValid()
        {
            return Program.CurrentLocation != null && string.IsNullOrEmpty(Parameters);
        }
    }
}
