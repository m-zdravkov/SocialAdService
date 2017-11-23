using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Model
{
    public enum PriceType { Range, Free, Unspecified, Bid }
    public class Price
    {
        public int Low { get; private set; }
        public int High { get; private set; }
        public PriceType Type { get; private set; }
    }
}
