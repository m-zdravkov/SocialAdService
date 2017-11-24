using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ad : Comment
    {
        public Price Price { get; set; }
        public ISet<string> Categories { get; set; }
        public string Title { get; set; }
        public DateTime ExpDate { get; set; }
        public int Views { get; set; }
    }
}
