using System.Runtime.Serialization;

namespace AutomatedBot.Engine
{
    internal class EngineException : Exception
    {
        public EngineException()
        {

        }

        public EngineException(string message) : base(message)
        {

        }

        public EngineException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public EngineException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
