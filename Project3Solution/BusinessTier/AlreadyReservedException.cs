using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class AlreadyReservedException : Exception
    {
        public AlreadyReservedException() { }
        public AlreadyReservedException(string message) : base(message) { }
        public AlreadyReservedException(string message, Exception inner) : base(message, inner) { }
        protected AlreadyReservedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
