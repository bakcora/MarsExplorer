using System;

namespace MarsExplorer.Business
{
    public class ExplorerCommand : Command
    {
        private readonly char _cmd;
        private readonly Rover _rover;
        private readonly Explorer _explorer;

        public ExplorerCommand(Explorer explorer, char cmd, Rover rover)
        {
            this._explorer = explorer;
            this._cmd = cmd;
            this._rover = rover;
        }
        
        public override char Undo(char cmd)
        {
            switch (cmd)
            {
                case 'L': return 'R';
                case 'R': return 'L';
                case 'M': return 'B';
                case 'B': return 'M';
                default: throw new ArgumentException("Invalid Command");
            }
        }

        public override void Execute()
        {
            _explorer.Operation(_cmd, _rover);
        }

        public override void UnExecute()
        {
            _explorer.Operation(Undo(_cmd), _rover);
        }
    }
}
