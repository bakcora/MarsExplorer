namespace MarsExplorer.Business
{
    public abstract class Command : ICommand
    {
        public abstract void Execute();
        public abstract void UnExecute();
        public abstract char Undo(char cmd);
    }
}
