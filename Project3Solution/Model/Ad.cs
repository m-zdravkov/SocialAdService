using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Model
{
    class Ad : Post
    {
        public Price Price = new Price();

        public ISet<String> Categories;

        public DateTime ExpDate { get; set; }

        public int Views { get; set; }


    }
}
