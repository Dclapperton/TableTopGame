using TableTopGame.Helpers;
using TableTopGame.Models;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame
{
    public class Location
    {
        public PositionX PositionX { get; set; }

        public PositionY PositionY { get; set; }

        public Orientation Orientation { get; set; }

        public bool Initialised { get; set; }
    }
}
