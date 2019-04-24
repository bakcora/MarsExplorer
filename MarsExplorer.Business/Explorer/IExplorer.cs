namespace MarsExplorer.Business
{
    public interface IExplorer
    {
        Rover Operation(char cmd, Rover rover);
    }
}
