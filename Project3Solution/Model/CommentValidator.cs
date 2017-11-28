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
        public static bool ValidateComment (this Comment comment)
        {
            bool result = true;

            result = result && ValidateReply(comment);
            result = result && ValidateContent(comment.Content);
        
        
            return result;
        }

        public static bool ValidateReply (Comment comment)
        {
            return comment.Indent > 0 && comment.ReplyId != null;
        }

        public static bool ValidateContent (string content)
        {
            return content.Length > 3 && content.Length <= 2000;
        }
        
    }
}
