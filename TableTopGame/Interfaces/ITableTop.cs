namespace TableTopGame.Interfaces
{
    public interface ITableTop
    {
        void Start();

        ICommand GetCommand();
    }
}
