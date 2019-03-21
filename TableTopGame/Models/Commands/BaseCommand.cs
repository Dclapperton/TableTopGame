using TableTopGame.Interfaces;

namespace TableTopGame.Models.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public string Parameters { get; set; }

        public abstract void Execute();

        public virtual bool IsValid()
        {
            return Program.CurrentLocation != null;
        }
    }
}
