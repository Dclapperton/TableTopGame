using TableTopGame.Interfaces;

namespace TableTopGame.Models
{
    public class PositionX : IPosition
    {
        const int PositionXMax = 5;
        const int PositionXMin = 0;

        public int Value { get; set; }

        public void Increment()
        {
            if (Value < PositionXMax)
            {
                Value++;
            }
        }

        public void Decrement()
        {
            if (Value > PositionXMin)
            {
                Value--;
            }
        }
    }
}
