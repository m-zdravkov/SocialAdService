using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Review : Comment
    {
        public int Stars { get; set; }

        //Comment attribute is inherited from Post Class, through Comment class.


    }
}
