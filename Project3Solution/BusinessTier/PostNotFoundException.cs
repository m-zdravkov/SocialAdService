using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    [Serializable]
    public class PostNotFoundException : Exception
    {
        public PostNotFoundException() { }
        public PostNotFoundException(string message) : base(message) { }
        public PostNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected PostNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
