using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    class LocationNotFoundException : Exception
    {
        public LocationNotFoundException() { }
        public LocationNotFoundException(string message) : base(message) { }
        public LocationNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected LocationNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
