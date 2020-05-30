using System;

namespace Calculator.Application.Common.Exceptions
{
    public class DivisionByZeroException : Exception
    {
        public DivisionByZeroException()
            : base()
        {
        }

        public DivisionByZeroException(string message)
            : base(message)
        {
        }

        public DivisionByZeroException(string message, Exception innerException)
           : base(message, innerException)
        {
        }

        public DivisionByZeroException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
