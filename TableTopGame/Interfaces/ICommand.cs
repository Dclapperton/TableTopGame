namespace TableTopGame.Interfaces
{
    public interface ICommand
    {
        string Parameters { get; set; }

        void Execute();

        bool IsValid();
    }
}
