using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.Business
{
    public interface IParser
    {
        Plateau ParseMessage(string msg);
    }
}
