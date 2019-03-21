namespace TableTopGame.Interfaces
{
    public interface IPosition
    {
        int Value { get; set; }

        void Increment();

        void Decrement();
    }
}
