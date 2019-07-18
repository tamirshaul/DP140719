using System;
using System.Runtime.Serialization;

namespace Test.Exercise12
{
    [Serializable]
    internal class ComputerNotReadyException : Exception
    {
        public ComputerNotReadyException()
        {
        }

        public ComputerNotReadyException(string message) : base(message)
        {
        }

        public ComputerNotReadyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ComputerNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}