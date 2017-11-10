using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Model
{
    public static class CommentValidator
    {
        public static bool validateComment (this Comment comment)
        {
            bool result = true;

            result = result && validateReply(comment);
            result = result && validateContent(comment.Content);
        
        
            return result;
        }

        public static bool validateReply (Comment comment)
        {
            return comment.level > 0 && comment.repliedTo != null;
        }

        public static bool validateContent (string content)
        {
            return content.Length > 3 && content.Length <= 2000;
        }
        
    }
}
