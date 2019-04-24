namespace MarsExplorer.Business
{
    public class RoverCommander : IRoverCommander
    {
        public Rover Rover { get; set; }
        public string CommandLine { get; set; }
    }
}
