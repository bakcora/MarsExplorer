using MarsExplorer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.Business
{
    public class Plateau :IPlateau
    {
        public string Name { get; set; }
        public Position UpperRightPoint { get; set; }
        public List<RoverCommander> RoverCommanders { get; set; }
        public Plateau()
        {
            this.RoverCommanders = new List<RoverCommander>();
        }
    }
}
