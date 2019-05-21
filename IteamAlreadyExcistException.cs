using System;
using System.Runtime.Serialization;

namespace mivhan
{
    [Serializable]
    internal class IteamAlreadyExcistException : Exception
    {
        public IteamAlreadyExcistException()
        {
        }

        public IteamAlreadyExcistException(string message) : base(message)
        {
        }

        public IteamAlreadyExcistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IteamAlreadyExcistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}