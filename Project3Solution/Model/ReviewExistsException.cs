using System;
using System.Runtime.Serialization;

namespace Model
{
    [Serializable]
    internal class ReviewException : Exception
    {
        public ReviewException()
        {
        }

        public ReviewException(string message) : base(message)
        {
        }

        public ReviewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReviewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}