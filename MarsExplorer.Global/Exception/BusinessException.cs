using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExplorer.Global.Exception
{
    public class BusinessException : BaseException
    {
       

        public BusinessException( string message)
            : base(message)
        {

        }

        public object[] ExtraData { get; set; }
    }
}
