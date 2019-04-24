namespace MarsExplorer.Global
{
    public class Enums
    {
        public static class LogType
        {
            public const string Error = "Error";
            public const string ErrorDatabase = "Error.Database";
            public const string Warning = "Warning";
            public const string Info = "Info";
            public const string Cache = "Cache";
            public const string Performance = "Performance";
        }

        public enum Directions
        {
            North = 0,
            West = 1,
            South = 2,
            East = 3
        }
        public enum Sides
        {
            Left = 0,
            Right = 1
        }
        public enum Way
        {
            Forward = 0,
            Backward = 1
        }
    }
}
