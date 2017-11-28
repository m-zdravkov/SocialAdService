using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public enum PriceType { Range, Free, Unspecified, Bid }
    public class Price
    {
        public string Id { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public PriceType Type { get; set; }
    }
}
