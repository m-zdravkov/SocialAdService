using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
    public enum BuyActionType { Reservations, Boosts }
    public class BuyActionViewModel
    {
        public BuyActionType Type { get; set; }
    }
}