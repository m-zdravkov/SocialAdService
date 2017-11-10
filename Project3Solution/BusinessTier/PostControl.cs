using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BusinessTier
{
    class PostControl
    {
        private static PostControl _instance;
        private PostControl ()
        {

        }

        public static PostControl GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new PostControl();
            }
            return _instance;
        }

        public void AddPost (Post post)
        {

        }

        
    }
}
