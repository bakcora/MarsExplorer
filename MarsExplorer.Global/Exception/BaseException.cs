using System;

namespace MarsExplorer.Global.Exception
{
    public abstract class BaseException : System.Exception
    {
        public string Code { get; private set; }

        private readonly string _message;

        public override string Message
        {
            get { return _message; }
        }

        protected BaseException(string code, string message)
        {
            Code = code;
            _message = message;
        }

        protected BaseException(string message)
        {
            Code = message;
            _message = message;
        }

        public override string ToString()
        {
            return string.Format("[Code:{0}]", Code) + Environment.NewLine + (_message ?? "") + Environment.NewLine + base.ToString();
        }
    }
}
