using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ad : Post
    {
        public Price Price { get; set; }
        public ISet<string> Categories { get; set; }
        public string Title { get; set; }
        public DateTime? ExpDate { get; set; }
        public int Views { get; set; }
    }
}
