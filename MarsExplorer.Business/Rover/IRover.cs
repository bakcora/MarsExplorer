using MarsExplorer.Global;

namespace MarsExplorer.Business
{
    public interface IRover
    {
        void Move(Enums.Way way);
        void Turn(Enums.Sides side);
        void Execute(char cmd);
        void Undo(int level);
        void Redo(int level);
    }
}
