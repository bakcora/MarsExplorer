using MarsExplorer.Global;
using MarsExplorer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsExplorer.Global.Helpers;
using System.Text.RegularExpressions;
using MarsExplorer.Utility.Extentions;

namespace MarsExplorer.Business
{
    public class Parser :IParser
    {
        public Plateau ParseMessage(string msg)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(msg))
                {
                    LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage : Message is empty.", MessageDetail = msg });
                    return null;
                }

                var lines = msg.Split(new string[] { "\n" }, StringSplitOptions.None);

                if (lines.Length < 3)
                {
                    LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage : Lines.Length is not enough.", MessageDetail = msg });
                    return null;
                }

                Plateau plateau = null;

                var rxPlatau = new Regex(Constants.PlatauCornerRegexPattern);

                if (rxPlatau.IsMatch(lines[0]) == false)
                {
                    LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage : Platau Corner coordinates are not valid.", MessageDetail = msg });
                    return null;
                }

                var platauCorner = lines[0].Split(' ');

                plateau = new Plateau();
                plateau.Name = "Haymana Platosu";
                plateau.UpperRightPoint = new Position();
                plateau.UpperRightPoint.X = platauCorner[0].Trim().ToInt32Value();
                plateau.UpperRightPoint.Y = platauCorner[1].Trim().ToInt32Value();


                LogHelper.Log(new LogModel { EventType = Enums.LogType.Info, Message = "ParserHelper.ParseMessage : Plateau created successfully", MessageDetail = msg });

                var rxPos = new Regex(Constants.RoverFirstRegexPattern);
                var rxCommand = new Regex(Constants.CommandRegexPattern);

                var roverIndex = 0;

                for (int i = 1; i < lines.Length; i = i + 2)
                {
                    if (i + 1 >= lines.Length)
                        break;

                    var roverPos = lines[i];

                    if (rxPos.IsMatch(roverPos) == false)
                    {
                        LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage : Rover position line is not valid.", MessageDetail = msg });
                        break;
                    }

                    var roverCommand = lines[i + 1].Trim();
                    if (rxCommand.IsMatch(roverCommand) == false)
                    {
                        LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage : Rover command line is not valid.", MessageDetail = msg });
                        break;
                    }

                    var posStr = roverPos.Split(' ');
                    var rover = new Rover();
                    rover.Plateau = plateau;
                    
                    rover.Position.X = posStr[0].Trim().ToInt32Value();
                    rover.Position.Y = posStr[1].Trim().ToInt32Value();
                    rover.Direction = Constants.LetterToDirection[posStr[2].Trim()];
                    rover.Name = "Rover_" + roverIndex;
                    rover.RoverId = roverIndex;

                    var rc = new RoverCommander();
                    rc.Rover = rover;
                    rc.CommandLine = roverCommand;
                    plateau.RoverCommanders.Add(rc);
                    roverIndex = roverIndex + 1;
                }

                return plateau;
            }
            catch (Exception exception)
            {
                LogHelper.Log(new LogModel { EventType = Enums.LogType.Error, Message = "ParserHelper.ParseMessage.", MessageDetail = msg, Exception = exception });
                return null;
            }
        }
    }
}
