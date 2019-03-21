using TableTopGame.Interfaces;

namespace TableTopGame.Models
{
    public class PositionY : IPosition
    {
        const int PositionYMax = 5;
        const int PositionYMin = 0;

        public int Value { get; set; }

        public void Increment()
        {
            if (Value < PositionYMax)
            {
                Value++;
            }
        }

        public void Decrement()
        {
            if (Value > PositionYMin)
            {
                Value--;
            }
        }
    }
}
