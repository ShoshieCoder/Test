using System;
using System.Runtime.Serialization;

namespace mivhan
{
    [Serializable]
    internal class IteamNotFoundException : Exception
    {
        public IteamNotFoundException()
        {
        }

        public IteamNotFoundException(string message) : base(message)
        {
        }

        public IteamNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IteamNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}