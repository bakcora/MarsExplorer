using MarsExplorer.Global;
using MarsExplorer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsExplorer.Business
{
    public class Rover : IRover
    {
        private List<Command> UndoList { get; set; }
        private int _index = 0;
        private Explorer Explorer { get; set; }

        public Rover()
        {
            Position = new Position();
            Direction = Enums.Directions.North;
            UndoList = new List<Command>();
            Explorer = new Explorer();
        }
        public string Name { get; set; }
        public Position Position { get; set; }
        public Enums.Directions Direction { get; set; }
        public void Move(Enums.Way way = Enums.Way.Forward)
        {
            var step = 1;
            if (way.Equals(Enums.Way.Backward))
                step = -1;

            switch (this.Direction)
            {
                case Enums.Directions.North:
                    {
                        this.Position.Y = this.Position.Y + step;
                        break;
                    }
                case Enums.Directions.West:
                    {
                        this.Position.X = this.Position.X - step;
                        break;
                    }
                case Enums.Directions.South:
                    {
                        this.Position.Y = this.Position.Y - step;
                        break;
                    }
                case Enums.Directions.East:
                    {
                        this.Position.X = this.Position.X + step;
                        break;
                    }
            }
        }
        public void Turn(Enums.Sides side)
        {
            switch (side)
            {
                case Enums.Sides.Left:
                    {
                        if (Direction.Equals(Enums.Directions.East))
                        {
                            Direction = Enums.Directions.North;
                            break;
                        }
                        Direction = (Enums.Directions)Enum.ToObject(typeof(Enums.Directions), ((byte)Direction) + 1);
                        break;
                    }
                case Enums.Sides.Right:
                    {
                        if (Direction.Equals(Enums.Directions.North))
                        {
                            Direction = Enums.Directions.East;
                            break;
                        }
                        Direction = Direction = (Enums.Directions)Enum.ToObject(typeof(Enums.Directions), ((byte)Direction) - 1);
                        break;
                    }
            }
        }

        public void Execute(char cmd)
        {
            var command = new ExplorerCommand(Explorer, cmd,this);
            command.Execute();
            UndoList.Add(command);
            _index++;
        }

        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_index < UndoList.Count - 1)
                {
                    var command = UndoList[_index++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_index > 0)
                {
                    var command = UndoList[--_index] as Command;
                    command.UnExecute();
                }
            }
        }

        public string GetPosition()
        {
            var sb = new StringBuilder();
            sb.Append(this.Position.X);
            sb.Append(" ");
            sb.Append(this.Position.Y);
            sb.Append(" ");
            sb.Append(Constants.DirectionToLetter[Direction]);
            return sb.ToString();
        }
    }
}
