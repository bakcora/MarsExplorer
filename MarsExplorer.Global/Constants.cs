using System.Collections.Generic;

namespace MarsExplorer.Global
{
    public static class Constants
    {
        public static Dictionary<Enums.Directions, string> DirectionToLetter = new Dictionary<Enums.Directions, string>()
        {
            {Enums.Directions.North,"N"},
            {Enums.Directions.South,"S"},
            {Enums.Directions.East,"E"},
            {Enums.Directions.West,"W"}
        };

        public static Dictionary<string, Enums.Directions> LetterToDirection = new Dictionary<string, Enums.Directions>()
        {
            {"N",Enums.Directions.North},
            {"S",Enums.Directions.South},
            {"E",Enums.Directions.East},
            {"W",Enums.Directions.West}
        };

        public static string CommandRegexPattern = @"[MRL]";
        public static string PlatauCornerRegexPattern = @"[0-9]+ [0-9]+";
        public static string RoverFirstRegexPattern = @"[0-9]+ [0-9]+ [NESW]";
    }
}
