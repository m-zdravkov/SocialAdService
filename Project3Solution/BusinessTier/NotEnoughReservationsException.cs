using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class NotEnoughReservationsException : Exception
    {
        public NotEnoughReservationsException() { }
        public NotEnoughReservationsException(string message) : base(message) { }
        public NotEnoughReservationsException(string message, Exception inner) : base(message, inner) { }
        protected NotEnoughReservationsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
