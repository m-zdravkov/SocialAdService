using System;
using System.Runtime.Serialization;

namespace Model
{
    [Serializable]
    internal class ReviewValidator : Exception
    {
        public ReviewValidator()
        {
        }

        public ReviewValidator(string message) : base(message)
        {
        }

        public ReviewValidator(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ReviewValidator(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}