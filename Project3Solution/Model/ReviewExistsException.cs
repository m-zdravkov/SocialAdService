using System;
using System.Runtime.Serialization;

namespace Model
{
    [Serializable]
    internal class ReviewExistsException : Exception
    {
        public ReviewExistsException()
        {
        }

        public ReviewExistsException(string message) : base(message)
        {
        }

        public ReviewExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReviewExistsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}