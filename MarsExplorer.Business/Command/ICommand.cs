namespace MarsExplorer.Business
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
